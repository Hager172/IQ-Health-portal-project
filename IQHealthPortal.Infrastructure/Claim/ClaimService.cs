using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.DTOs.itemsDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Application.Interfaces.services;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Identity.Services;
using IQHealthPortal.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Data;
using System.Text;

namespace IQHealthPortal.Infrastructure.Claims
{
    public class ClaimService:IClaimService
    {
        private readonly IUnitOfWork unitOfWork;
        //private readonly IDbConnection _context;

        public ClaimService(IUnitOfWork _unitofwork)
        {
           this.unitOfWork = _unitofwork;
        }
       
        //pre validate

        public async Task<bool> ValidateClaimAsync(ClaimDto claim, OnlineUserDTO user)
        {
            // 1. Update phone
            if (!string.IsNullOrEmpty(claim.Phone))
                {
                var member = await unitOfWork.memberrepository.GetMemberById(claim.MembId);
               

                if (member != null &&
                    (string.IsNullOrEmpty(member.MemberTele) || member.MemberTele.Length < 11))
                    {
                    await unitOfWork.memberrepository.UpdateMemberPhoneAsync(member.MemberId, claim.Phone);



                }
                }

            // 2. Future date
            if (DateTime.Now < claim.ServiceDate)
                {
                claim.MsgHolder = "Service date can't be in future!";
                return false;
                }

            // 3. Product validation
            if (claim.Services == null || claim.Services.Count == 0 || claim.Services[0] == null)
                {
                claim.MsgHolder = "No services Found!";
                return false;
                }

            //string gp = user.VType == "Ph" ? "directGrace" : "lr_directGrace";
            string gp = "lr_directGrace";
            // 4. Get status using mapped function
            //var status = await _context.Set<Member>()
            //    .Where(m => m.MemberId == claim.MembId)
            //    .Select(m => DbFunctionsExtensions.MemberStatus(claim.MembId, DateTime.Now))
            //    .FirstOrDefaultAsync();
            var status = await unitOfWork.memberrepository
    .GetMemberStatusAsync(claim.MembId);

            if (status == null)
                {
                claim.MsgHolder = "Member Not Found";
                return false;
                }

            // 5. Contract
            var contract = await unitOfWork.memberrepository
         .GetActiveContractAsync(claim.MembId);

            if (contract == null)
                {
                claim.MsgHolder = "Member's contract has expired!";
                return false;
                }

            claim.Contract = contract;

            // 6. isNew check
            string formId = claim.PresId + user.VType;
            string formIdZero = "0" + claim.PresId + user.VType;

            var isNew = await unitOfWork.memberrepository
       .GetApprovalStatusAsync(formId, formIdZero);

            // 7. Grace period
            var gracePeriod = await unitOfWork.memberrepository.GetGracePeriodAsync(gp);

            var daysDiff = (DateTime.Now - claim.ServiceDate).TotalDays;

            if (daysDiff > gracePeriod)
                {
                claim.MsgHolder = $"Claim expired. Must be within {gracePeriod} days!";
                return false;
                }

            // 8. Status validation
            if (status != "V")
                {
                claim.MsgHolder = status switch
                    {
                        "S0" => "Member Doesn't Exist!",
                        "S1" => "Member isn't Active!",
                        "S2" => "Member's Customer isn't Active!",
                        "S3" => "Parent Customer isn't Active!",
                        "S4" => "Contract is Expired!",
                        "S5" => "Member Sub Date is After Approval Date!",
                        _ => "Invalid status"
                        };

                return false;
                }

            // 9. Duplicate check
            switch (isNew)
                {
                case "P":
                    claim.MsgHolder = "Already processed";
                    return false;
                case "C":
                    claim.MsgHolder = "Already rejected";
                    return false;
                case "N":
                    claim.MsgHolder = "Pending";
                    return false;
                }

            return true;
        }



        //validate item 
        public async Task<OnlineServiceItemDto> ValidateItemAsync(OnlineServiceItemDto item, string diagnosis, string membId, int maxDays)
        {
            var holdStatus = item.Status;
            item.Status = "a";

            if (holdStatus == "r")
                return Reject(item, "Related diagnose is not covered!");

            if (holdStatus == "o")
                return Reject(item, "Related diagnose has been repeated this week!");

            var data = await unitOfWork.ClaimRepository.GetPharmaItemAsync(item.Id);

            if (data == null)
                return Reject(item, "Item Not Found!");

            item.Name = data.Name;
            item.Price = data.Price;

            if (data.Covered == "No")
                return Reject(item, "Item Is Not Covered!");

            if (item.Quantity > 1 && item.IsOneUnit)
                return Pending(item, "Quantity exceeds limit");

            return item;
        }


        private OnlineServiceItemDto Reject(OnlineServiceItemDto item, string reason)
        {
            item.Status = "r";
            item.Reason = reason;
            return item;
        }

        private OnlineServiceItemDto Pending(OnlineServiceItemDto item, string reason)
        {
            item.Status = "p";
            item.Reason = reason;
            return item;
        }




        public async Task<bool> SaveClaimAsync(ClaimDto claim, OnlineUserDTO currentUser)
        {
            await unitOfWork.BeginTransactionAsync();
            try
            {
                float coinsRatio = 0;
                int medItem = 0;
                string aType = "";

                // 1. Determine type
                switch (currentUser.VType)
                {
                    case "Ph":
                        medItem = 5;
                        aType = "Pharmacy";
                        break;

                    case "Sc":
                        medItem = 1220;
                        aType = "Public";
                        break;

                    case "Dt":
                        medItem = 7;
                        aType = "Public";
                        break;

                    case "LR":
                    case "Lb":
                        medItem = 107;
                        aType = "Public";
                        break;

                    case "Rd":
                        medItem = 106;
                        aType = "Public";
                        break;
                }

                // 2. Get Coinsurance + MaxValue
                var coinsData = await unitOfWork.ClaimRepository.GetCoinsuranceDataAsync(claim.MembId, claim.Contract, medItem);


                coinsRatio = coinsData.Coinsurance;
                claim.MaxValue = coinsData.MaxValue;


                claim.Coinsurance = coinsRatio;

                // 3. Generate Approval ID
                //var approvalId = await _context.Database
                //    .SqlQuery<long>($"SELECT dbo.f_get_new_approval_id(3)")
                //    .FirstAsync();
                var approvalId = await unitOfWork.ClaimRepository
    .GetNewApprovalIdAsync();


                claim.ApprovalCode = approvalId;

                string formId = claim.PresId == "-564000"? await unitOfWork.ClaimRepository.GetNewClaimIdAsync(currentUser.VType): claim.PresId;

                formId += currentUser.VType;

                // 4. Insert Approval
                var approval = new ApprovalClaimDto
                {
                    ApprovalId = claim.ApprovalCode,
                    ApprovalDate = DateTime.Now,
                    OnlineBCode = currentUser.Office,
                    MemberId = claim.MembId,
                    Notes = claim.Notes,
                    LastUpdateBy = currentUser.UserName,
                    LastUpdateDate = DateTime.Now,
                    LastUpdateFrom = "Online System",
                    //VendorId = currentUser.Vendor,
                    VendorId = "Ph0334",
                    ApStatus = "N",
                    ApType = aType,
                    Coinsurance = 0,
                    OnlineUser = currentUser.UserName,
                    OnlineStatus = "N",
                    OnlineLud = DateTime.Now,
                    FormId = formId,
                    FormDate = DateOnly.FromDateTime(claim.ServiceDate),
                    MaxValue = claim.MaxValue,
                    IsOnline = "1",
                    RequestSource = "Online",
                  
                };
                await unitOfWork.ApprovalRepository.AddApprovalAsync(approval);

                //await unitOfWork.CommitAsync();
                // 5. Diagnosis
                var diagnosisList = claim.DiagnosisInsString
        .Split(",")
        .ToList();

                await unitOfWork.ClaimRepository
                    .AddDiagnosesAsync(claim.ApprovalCode, diagnosisList);

                // 6. Services
                var services = new List<ApprovalServiceDto>();

                //for (int i = 0; i < claim.Product.Length; i++)
                //{
                //    var qty = claim.Qty;

                //    services.Add(new ApprovalServiceDto
                //    {
                //        ItemSerial = i + 1,
                //        ApprovalId = claim.ApprovalCode,
                //        ServiceId = claim.Product[i],
                //        ApQty = qty,
                //        Price = claim.Price[i],
                //        Days = 1,
                //        LastUpdateDate = DateTime.Now,
                //        LastUpdateBy = currentUser.UserName,
                //        LastUpdateFrom = "OnlineSystem",
                //        Qty = qty,
                //        DoseUnits = claim.Units[i] == 0 ? 1 : claim.Units[i],
                //        DoseRepeat = claim.Rep[i] == 0 ? 1 : claim.Rep[i],
                //        DoseDuration = claim.Duration[i] == 0 ? 1 : claim.Duration[i],
                //        DoseDurType = 1,
                //        MedItem = medItem,
                //        Coinsurance = coinsRatio
                //    });
                //}
                foreach (var service in claim.Services)
                {
                    services.Add(new ApprovalServiceDto
                    {
                        ApprovalId = claim.ApprovalCode,

                        ServiceId = service.ProductId,

                        ApQty = service.Qty,

                        Qty = service.Qty,

                        Price = service.Price,

                        DoseUnits = service.Units == 0
                            ? 1
                            : service.Units,

                        DoseRepeat = service.Rep == 0
                            ? 1
                            : service.Rep,

                        DoseDuration = service.Duration == 0
                            ? 1
                            : service.Duration,

                        Days = 1,

                        DoseDurType = 1,

                        MedItem = medItem,

                        Coinsurance = coinsRatio,

                        ItemSerial = services.Count + 1,

                        LastUpdateBy = currentUser.UserName,

                        LastUpdateDate = DateTime.Now,

                        LastUpdateFrom = "OnlineSystem"
                    });
                }

                await unitOfWork.ClaimRepository
                    .AddServicesAsync(services);
                // 7. Log
                var totalPrice = await unitOfWork.ClaimRepository.GetTotalPriceAsync(claim.ApprovalCode);


                var logDto = new ApprovalLogDto
                {
                    ApprovalId = claim.ApprovalCode,
                    NumServices = claim.Services.Count,
                    ApprovalDate = approval.ApprovalDate,
                    MemberId = claim.MembId,
                    Notes = claim.Notes,
                    ApprovalStatus = "N",
                    Price = totalPrice,
                    LastUpdateBy = currentUser.UserName,
                    LastUpdateDate = DateTime.Now,
                    LastUpdateFrom = "Online System",
                    Action = 201
                };

                await unitOfWork.ClaimRepository.AddLogAsync(logDto);

                await unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                await unitOfWork.RollbackAsync();
                return false;
            }
        }

        
        public async Task<ClaimResultDto>
            ValidateClaimAfterAsync(ClaimDto claim)
        {
            var result = new ClaimResultDto
            {
                ClaimId = claim.ApprovalCode.ToString(),
                PresId = claim.PresId.Length > 2
                    ? claim.PresId[..^2]
                    : claim.PresId
            };

            var validDiagnosis =
                await unitOfWork.ClaimRepository
                    .HasValidDiagnosisAsync(claim.DiagnosisString);

            if (!validDiagnosis)
            {
                await CancelClaim(claim, "Related Diagnose not Covered!");

                result.Result = "Canceled";

                return result;
            }

            var items =
                await unitOfWork.ClaimRepository
                    .GetClaimItemsAsync(claim.ApprovalCode);

            var statusList = new List<string>();

            var processed = new HashSet<int?>();

            foreach (var item in items)
            {
                if (processed.Contains(item.Id))
                {
                    item.Status = "r";
                    item.Reason = "Repeated item!";

                    statusList.Add("r");

                    continue;
                }

                processed.Add(item.Id);

                var validated =
                    await ValidateItemAsync(
                        item,
                        claim.DiagnosisString,
                        claim.MembId,
                        7);

                statusList.Add(validated.Status);
            }

            if (!statusList.Contains("p"))
            {
                if (statusList.Contains("a"))
                {
                    result.Result = "Approved";

                    await ApproveClaim(claim);
                }
                else
                {
                    result.Result = "Canceled";

                    await CancelClaim(claim, "All items rejected");
                }
            }
            else
            {
                result.Result = "Pending";
            }

            result.Items = items;

            return result;
        }
        private async Task ApproveClaim(ClaimDto claim)
        {
            // 1. Update Approval Table
            //var approval = await _context.Approvals
            //    .FirstOrDefaultAsync(x => x.ApprovalCode == claim.ApprovalCode);

            //if (approval != null)
            //{
            //    approval.Status = "a"; // Approved
            //    approval.UpdatedDate = DateTime.Now;
            //}

            //// 3. Save Changes
            //await _context.SaveChangesAsync();

            await unitOfWork.ClaimRepository
        .UpdateApprovalStatusAsync(
            claim.ApprovalCode,
            "a");

            // 4. Logging
            //await InsertLog(claim.ApprovalCode, "Approved", "Claim Approved Successfully");

            //رقم الاكشن هيتغير على حسب الاكشن الصح 
            await unitOfWork.ClaimRepository
       .InsertClaimLogAsync(
           (int)claim.ApprovalCode,
           201,
           "Claim Approved Successfully");
        }
        private async Task CancelClaim(ClaimDto claim, string reason)
        {
            await unitOfWork.ClaimRepository
       .UpdateApprovalStatusAsync(
           claim.ApprovalCode,
           "c",
           reason);

            await unitOfWork.ClaimRepository
                .RejectClaimItemsAsync(
                    claim.ApprovalCode,
                    reason);

            await unitOfWork.ClaimRepository
                .InsertClaimLogAsync(
                    (int)claim.ApprovalCode,
                    202,
                    reason);

            //// 4. Logging
            //await InsertLog(claim.ApprovalCode, "Canceled", reason);
        }


        public async Task<MemberInfoDto?> GetMemberInfoAsync(
    string memberId,
    string type)
        {
            var member = await unitOfWork.memberrepository.GetMemberAsync(memberId);

            if (member == null)
                return null;

            var contractId =
                await unitOfWork.memberrepository.GetActiveContractAsync(memberId);

            int medItem = type switch
            {
                "Ph" => 5,
                "Rd" => 106,
                "LR" => 107,
                "Lb" => 107,
                "Dt" => 7,
                "Sc" => 14,
                _ => 0
            };
            decimal coinsurance = 0;

            if (!string.IsNullOrEmpty(contractId) && medItem > 0)
            {
                var coinsData =
                    await unitOfWork.ClaimRepository.GetCoinsuranceDataAsync(
                        memberId,
                        contractId,
                        medItem);

                coinsurance = (decimal)coinsData.Coinsurance;
            }

            var parentName = "";

            if (!string.IsNullOrEmpty(member.ParentName))
            {
                parentName =
                    await unitOfWork.memberrepository.GetParentNameAsync(
                        member.ParentName);
            }

            return new MemberInfoDto
            {
                MemberName = member.MemberName,
                CustomerName = member.CustomerName,
                Mobile = member.Mobile,
                BirthDate = member.BirthDate?.ToString(),
                CardImageUrl = $"/docs/contracts/{contractId}/{memberId}.jpg",
                Coinsurance = coinsurance,
                ParentName = parentName,
                MemberNationalId=member.MemberNationalId
            };
        }


        public async Task<List<ApprovalDetailDto>> getbranchapproval(string branchId)
        {
            if (branchId.Split('.')[1] == "0")
            {

                return await unitOfWork.ClaimRepository.GetmainBranchApprovalsAsync(branchId.Split('.')[0]);
            }

            return await unitOfWork.ClaimRepository.GetBranchApprovalsAsync(branchId);
        }
        //private async Task InsertLog(int approvalCode, string action, string message)
        //{
        //    var log = new ClaimLog
        //    {
        //        ApprovalCode = approvalCode,
        //        Action = action,
        //        Message = message,
        //        CreatedAt = DateTime.Now
        //    };

        //    await _context.ClaimLogs.AddAsync(log);
        //    await _context.SaveChangesAsync();
        //}

        //[HttpPost]
        //public async Task<ResponseMessage> CreateClaim(HttpRequest request)
        //{
        //    ResponseMessage responseMessage = new ResponseMessage();

        //    var session = request.HttpContext.Session;

        //    var sf = (ServicesFactory)session.GetObject(Constants.SERVICES_FACTORY_ATTRIBUTE_NAME);
        //    var ds = sf.GetDocumentService();
        //    var us = sf.GetUserService();

        //    string po = Encoding.UTF8.GetString(
        //        Encoding.GetEncoding("ISO-8859-1").GetBytes(request.Form["notes"])
        //    );

        //    try
        //    {
        //        Claim claimToBeCreated = new Claim();
        //        User currentUser = session.GetObject<User>("user");

        //        Imssqdb mydb = currentUser.Client == "1"
        //            ? new mssqdb()
        //            : new mssqldb();

        //        // Populate Claim from Request
        //        MvcHelper.PopulateBeanByRequestParametersNew(request, claimToBeCreated, myVariables.ClaimNames);

        //        claimToBeCreated.Notes = po;

        //        if (mydb.ValidateClaimBefore(claimToBeCreated, currentUser))
        //        {
        //            if (mydb.SaveClaim(claimToBeCreated, currentUser))
        //            {
        //                claimResult result;

        //                switch (claimToBeCreated.VType)
        //                {
        //                    case "Ph":
        //                        result = mydb.ValidateClaimAfter(claimToBeCreated);
        //                        break;

        //                    case "LR":
        //                    case "Sc":
        //                    case "Lb":
        //                    case "Rd":
        //                    case "Dt":
        //                        result = mydb.ValidateRadsAfter(claimToBeCreated);
        //                        break;

        //                    default:
        //                        result = new claimResult();
        //                        break;
        //                }

        //                responseMessage.OverAllStatus = true;

        //                if (result.Messege == null)
        //                    result.Messege = "O";

        //                if (result.Items == null)
        //                    result.Items = new List<object>();

        //                responseMessage.Data = result;

        //                try
        //                {
        //                    string tempPath = myVariables.DocumentRoot + claimToBeCreated.ApprovalCode;

        //                    if (!Directory.Exists(tempPath))
        //                        Directory.CreateDirectory(tempPath);

        //                    string cmd = "";

        //                    foreach (var file in request.Form.Files)
        //                    {
        //                        var fileName = mydb.ValidateString(file.FileName);

        //                        long random = (long)((new Random().NextDouble() + 1) * 1000);
        //                        string hashName = random + fileName.GetHashCode() + Path.GetExtension(fileName);

        //                        string fullPath = Path.Combine(tempPath, hashName);

        //                        using (var stream = new FileStream(fullPath, FileMode.Create))
        //                        {
        //                            await file.CopyToAsync(stream);
        //                        }

        //                        if (currentUser.Client != "1")
        //                        {
        //                            cmd += $"INSERT INTO approvals_archive(name,path,approval_id,last_update_by,last_update_date,attached_name_id) " +
        //                                   $"VALUES('{fileName}','{hashName}','{claimToBeCreated.ApprovalCode}','Online System',GETDATE(),14);";
        //                        }
        //                        else
        //                        {
        //                            cmd += $"INSERT INTO Member_Documents(Member_id,action_code,Doc_date,doc_name,doc_path,LAST_UPDATE_BY,LAST_UPDATE_DATE,LAST_UPDATE_FROM) " +
        //                                   $"VALUES('{claimToBeCreated.MembId}','{claimToBeCreated.ApprovalCode}',GETDATE(),'{fileName}','{hashName}','{currentUser.UserName}',GETDATE(),'Online System');";
        //                        }
        //                    }

        //                    if (!string.IsNullOrEmpty(cmd))
        //                    {
        //                        if (result.Result != "Canceled")
        //                        {
        //                            cmd += currentUser.Client != "1"
        //                                ? $"update approvals set private_notes = isnull(private_notes,'') + 'تم اضافة مرفقات' where approval_id = {claimToBeCreated.ApprovalCode};"
        //                                : $"update approvals_temp set remarks_not_printed = isnull(remarks_not_printed,'') + 'تم اضافة مرفقات' where APPROVAL_CODE = {claimToBeCreated.ApprovalCode};";
        //                        }

        //                        mydb.SelectRow(cmd);
        //                    }
        //                }
        //                catch { }

        //                _ = Task.Run(() =>
        //                    mydb.SendToLocal(claimToBeCreated.ApprovalCode.ToString(), 1)
        //                );

        //                string msg = "";

        //                switch (result.Result)
        //                {
        //                    case "Approved":
        //                        msg = $"تم الموافقة على الطلب رقم {result.ClaimId} من {currentUser.FirstName} {currentUser.LastName}";
        //                        break;

        //                    case "Pending":
        //                        msg = $"تم استلام طلب الموافقة رقم {result.ClaimId} من {currentUser.FirstName} {currentUser.LastName}";
        //                        break;

        //                    case "Canceled":
        //                        msg = $"تم رفض الطلب رقم {result.ClaimId} من {currentUser.FirstName} {currentUser.LastName}";
        //                        break;
        //                }

        //                _ = Task.Run(() =>
        //                    mydb.SendTSMS(claimToBeCreated.Phone, msg)
        //                );
        //            }
        //            else
        //            {
        //                var result = new claimResult
        //                {
        //                    Messege = "Failed to Created Claim. Submission Error",
        //                    Items = new List<object>()
        //                };

        //                responseMessage.Data = result;
        //            }
        //        }
        //        else
        //        {
        //            var result = new claimResult
        //            {
        //                Result = "L",
        //                Messege = "Failed to Created Claim. Validation Error " + claimToBeCreated.MsgHolder,
        //                Items = new List<object>()
        //            };

        //            responseMessage.OverAllStatus = false;
        //            responseMessage.Data = result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        responseMessage.OverAllStatus = true;
        //        responseMessage.Message = ex.Message;
        //    }

        //    return responseMessage;
        //}
    }
}
