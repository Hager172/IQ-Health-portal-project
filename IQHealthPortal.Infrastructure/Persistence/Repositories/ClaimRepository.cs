using ACMS_ONLINE_INFRASTRUCTURE.Data;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.DTOs.itemsDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Services.Identity.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{

    public class ClaimRepository : IClaimRepository
    {

        private readonly IConnectionStringProvider connectionStringProvider;

        public ClaimRepository(IConnectionStringProvider connectionStringProvider)
        {

            this.connectionStringProvider = connectionStringProvider;

        }


        public ApplicationDbContext CreateContext()
        {
            var connection =
                connectionStringProvider.GetCurrentConnectionString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connection)
                .Options;

            return new ApplicationDbContext(options);
        }
        public async Task<OnlineServiceItemDto?> GetPharmaItemAsync(int? itemId)
        {
            using var context = CreateContext();

            return await (
                from p in context.AcmsPharmas
                where p.Id == itemId && p.Active == 1
                select new OnlineServiceItemDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Covered = p.Availability
                }
            ).FirstOrDefaultAsync();
        }



        public async Task<(float Coinsurance, float MaxValue)> GetCoinsuranceDataAsync(string membId, string contractId, int medItem)
        {
            using var _context = CreateContext();
            var data = await (
                from pi in _context.PlanItems
                join mp in _context.MemberPlans on pi.PlanId equals mp.PlanCode
                join cp in _context.ContractPlans on pi.PlanId equals cp.ContractPlanId
                where mp.MemberCode == membId
                      && cp.ContractId == contractId
                      && pi.ItemId == medItem
                select new
                {
                    Share = pi.PlanItemCopaymentValue,
                    MaxVal = pi.MaxValue
                }
            ).FirstOrDefaultAsync();
            return (
                (float)(data?.Share ?? 0),
                (float)(data?.MaxVal ?? 0)
            );
        }
        //public async Task<(float Coinsurance, float MaxValue)>
        //GetCoinsuranceDataAsync(
        //    string membId,
        //    string contractId,
        //    int medItem)
        //    {
        //        using var context = CreateContext();

        //        var memberPlan = await context.MemberPlans
        //            .Include(x => x.PlanCodeNavigation)
        //                .ThenInclude(x => x.PlanItems)
        //            .FirstOrDefaultAsync(x =>
        //                x.MemberCode == membId &&
        //                x.PlanCodeNavigation.ContractId 
        //                    .Any(c => c.ContractId == contractId));

        //        if (memberPlan == null)
        //            return (0, 0);

        //        var item = memberPlan
        //            .PlanCodeNavigation
        //            .PlanItems
        //            .FirstOrDefault(x => x.ItemId == medItem);

        //        if (item == null)
        //            return (0, 0);

        //        return (
        //            (float)(item.PlanItemCopaymentValue ?? 0),
        //            (float)(item.MaxValue ?? 0)
        //        );
        //    }
        public async Task<long> GetNewApprovalIdAsync()
        {
            using var context = CreateContext();

            long seed = 2600000000;

            var lastId = await context.Database
                .SqlQuery<long>(
                    $"SELECT dbo.f_get_new_approval_id(0, {seed}) AS Value")
                .FirstAsync();

            return lastId + 1;
        }
        public async Task<string> GetNewClaimIdAsync(string vType)
        {
            using var context = CreateContext();

            return await context.Database
                .SqlQuery<string>(
                    $"SELECT dbo.GET_NEWCLAIMID({vType}) AS Value")
                .FirstAsync();
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            using var _context = CreateContext();
            return await _context.Database.BeginTransactionAsync();
        }


        public async Task AddDiagnosesAsync(
        long approvalId,
        List<string> diagnosisIds)
        {
            using var _context = CreateContext();

            var approval = await _context.Approvals
                .Include(x => x.Diagnoses)
                .FirstOrDefaultAsync(x => x.ApprovalId == approvalId);

            if (approval == null)
                return;

            var diagnoses = await _context.OnlineDiagnoses
                .Where(x => diagnosisIds.Contains(x.Id))
                .ToListAsync();

            foreach (var diagnosis in diagnoses)
            {
                approval.Diagnoses.Add(diagnosis);
            }

            await _context.SaveChangesAsync();
        }

        public async Task AddServicesAsync(
    List<ApprovalServiceDto> services)
        {
            using var _context = CreateContext();

            var entities = services.Select(dto => new ApprovalService
            {
                ItemSerial = dto.ItemSerial,
                ApprovalId = dto.ApprovalId,
                ServiceId = dto.ServiceId,
                ApQty = dto.ApQty,
                Price = dto.Price,
                Days = dto.Days,
                LastUpdateDate = dto.LastUpdateDate,
                LastUpdateBy = dto.LastUpdateBy,
                LastUpdateFrom = dto.LastUpdateFrom,
                Qty = dto.Qty,
                DoseUnits = dto.DoseUnits,
                DoseRepeat = dto.DoseRepeat,
                DoseDuration = dto.DoseDuration,
                DoseDurType = dto.DoseDurType,
                MedItem = dto.MedItem,
                Coinsurance = dto.Coinsurance
            });

            await _context.ApprovalServices.AddRangeAsync(entities);

            await _context.SaveChangesAsync();
        }

        public async Task<double?> GetTotalPriceAsync(long approvalId)
        {
            using var _context = CreateContext();

            return await _context.ApprovalServices
                .Where(x => x.ApprovalId == approvalId)
                .SumAsync(x => x.Qty * x.Price);
        }

        public async Task AddLogAsync(ApprovalLogDto logDto)
        {
            using var _context = CreateContext();

            var log = new ApprovalsLog
            {
                ApprovalId = logDto.ApprovalId,
                NumServices = logDto.NumServices,
                ApprovalDate = logDto.ApprovalDate,
                MemberId = logDto.MemberId,
                Notes = logDto.Notes,
                ApprovalStatus = logDto.ApprovalStatus,
                Price = logDto.Price ?? 0,
                LastUpdateBy = logDto.LastUpdateBy,
                LastUpdateDate = logDto.LastUpdateDate,
                LastUpdateFrom = logDto.LastUpdateFrom,
                Action = logDto.Action
            };

            await _context.ApprovalsLogs.AddAsync(log);

            await _context.SaveChangesAsync();
        }


        public async Task<bool> HasValidDiagnosisAsync(string diagnosisString)
        {

            using var _context = CreateContext();
            return await _context.OnlineDiagnoses
                .AnyAsync(d =>
                    diagnosisString.Contains(d.Id)
                    && d.Type != 0);
        }

        public async Task<List<OnlineServiceItemDto>>
    GetClaimItemsAsync(long approvalId)
        {

            using var _context = CreateContext();

            return await _context.ApprovalServices
                .Where(x => x.ApprovalId == approvalId)
                .OrderBy(x => x.ItemSerial)
                .Select(x => new OnlineServiceItemDto
                {
                    Id = x.ServiceId,
                    Quantity = x.ApQty,
                    Days = x.Days,
                    Status = x.OnlineStatus,
                    MedItem = x.MedItem
                })
                .ToListAsync();
        }

        public async Task UpdateApprovalStatusAsync(
    long approvalCode,
    string status,
    string? reason = null)
        {

            using var _context = CreateContext();
            var approval = await _context.Approvals
                .FirstOrDefaultAsync(x => x.ApprovalId == approvalCode);

            if (approval == null)
                return;

            approval.ApStatus = status;
            approval.LastUpdateDate = DateTime.Now;

            //if (!string.IsNullOrWhiteSpace(reason))
            //    approval.Rea = reason;
        }
        public async Task RejectClaimItemsAsync(
    long approvalCode,
    string reason)
        {
            using var _context = CreateContext();

            var items = await _context.ApprovalServices
                .Where(x => x.ApprovalId == approvalCode)
                .ToListAsync();

            foreach (var item in items)
            {
                item.OnlineStatus = "r";
                //item.Reason = reason;
            }
        }

        public async Task InsertClaimLogAsync(
      int approvalCode,
      int action,
      string message,
      string userName = "Online System")
        {
            using var _context = CreateContext();

            var log = new ClaimLog
            {
                CodeId = approvalCode,
                TypeId = action,
                Note = message,

                LastUpdateBy = userName,
                LastUpdateDate = DateTime.Now,
                LastUpdateFrom = "Online System"
            };

            await _context.ClaimLogs.AddAsync(log);

        }


        public async Task<List<DiagnosisDto>>
           GetDiagnosisAsync(string? term)
        {
            using var context = CreateContext();

            var query =
                context.OnlineDiagnoses
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(term))
            {
                query = query.Where(x =>
                    x.Name.Contains(term));
            }

            return await query
                .Select(x => new DiagnosisDto
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .Take(20)
                .ToListAsync();
        }

        public async Task<List<ProductLookupDto>> SearchPharmaProductsAsync(string? term)
        {
            using var context = CreateContext();

            return await context.AcmsPharmas
                .Where(x => string.IsNullOrEmpty(term) || x.Name.Contains(term))
                .Take(20)
                .Select(x => new ProductLookupDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    price = x.Price
                })
                .ToListAsync();
        }

        public async Task<List<ProductLookupDto>> SearchContractServicesAsync(string? term)
        {
            using var context = CreateContext();

            return await context.ContractServices
                .Where(x => string.IsNullOrEmpty(term) || x.ContractServiceName.Contains(term))
                .Take(20)
                .Select(x => new ProductLookupDto
                {
                    Id = x.ContractServiceId,
                    Name = x.ContractServiceName,
                    price = x.ContractServicePrices
                })
                .ToListAsync();
        }

        public async Task<OnlineUserDTO?> GetUserByIdAsync(string userId)
        {
            var connection = connectionStringProvider.GetDefaultConnectionString();

            var options = new DbContextOptionsBuilder<IdentityContext>()
                .UseSqlServer(connection)
                .Options;

            await using var context = new IdentityContext(options);

            if (string.IsNullOrEmpty(userId))
                return null;

            return await context.OnlineUserClients
                .Where(x => x.UserId == userId)
                .Select(x => new OnlineUserDTO
                {
                    VType = x.V_Type,
                    Office = x.BranchId,
                    Status = x.Status
                })
                .FirstOrDefaultAsync();
        }

        public async Task<bool?> GetUserStatus(string userId)
        {
            var connection = connectionStringProvider.GetDefaultConnectionString();

            var options = new DbContextOptionsBuilder<IdentityContext>()
                .UseSqlServer(connection)
                .Options;

            await using var context = new IdentityContext(options);

            if (string.IsNullOrEmpty(userId))
                return null;

         var status=  await context.OnlineUserClients
                .Where(x => x.UserId == userId)
                .Select(x =>x.Status)
                .FirstOrDefaultAsync();

            if(status == null)
                return null;
            if (status == 1)
                return true;
            else
                return false;
             
        }
        public async Task<List<ApprovalDetailDto>> GetBranchApprovalsAsync(string? term)
        {
            using var context = CreateContext();

            return await context.Approvals
.Where(x => x.OnlineBCode == term
         && x.RequestSource == "Online"
         && x.OnlineStatus != "C").Select(x => new ApprovalDetailDto
                {
                    ApprovalId = x.ApprovalId,
                    ApprovalDate = x.ApprovalDate,
                    ApStatus = x.OnlineStatus,
                    ApType = x.ApType,
                    RequestSource = x.RequestSource,
                    Notes = x.Notes,
                    MemberId = x.MemberId,
                    VendorId = x.VendorId,

                })
                .ToListAsync();

        }



        public async Task<List<ApprovalDetailDto>> GetBranch3mApprovalsAsync(string? term)
        {
            using var context = CreateContext();

            var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            var startDate = endDate.AddMonths(-3);

            return await context.Approvals
                .Where(x => x.OnlineBCode == term
                         && x.RequestSource == "Online"
                         && x.OnlineStatus == "P"
                         && x.ApprovalDate >= startDate
                         && x.ApprovalDate < endDate) 
                .Select(x => new ApprovalDetailDto
                {
                    ApprovalId = x.ApprovalId,
                    ApprovalDate = x.ApprovalDate,
                    ApStatus = x.OnlineStatus,
                    ApType = x.ApType,
                    RequestSource = x.RequestSource,
                    Notes = x.Notes,
                    MemberId = x.MemberId,
                    MemberName = x.Member.MemberName,
                    CompanyName = context.CustomerContracts.Where(c=>c.CustomerContractId==x.ContractId).Select(c=>c.CustomerContractCustomer.CustomerName).FirstOrDefault(),
                    BranchName = context.OnlineUsers
    .Where(u => u.Office == x.OnlineBCode)
    .Select(u => u.FirstName)
    .FirstOrDefault(),
                    VendorId = x.VendorId,
                })
                .ToListAsync();
        }

        //public async string GetBranchName(string? office)
        //{
           
        //    using var context = CreateContext();


        //    var BranchName = context.OnlineUsers.Where(u => u.Office == office).Select(u => u.FirstName).FirstOrDefault();

        //    return BranchName;
        //}
        //var connection = connectionStringProvider.GetDefaultConnectionString();

        //var options = new DbContextOptionsBuilder<IdentityContext>()
        //    .UseSqlServer(connection)
        //    .Options;

        //await using var context = new IdentityContext(options);

        //var userid = await context.OnlineUserClients
        //    .Where(u => u.BranchId == office)
        //    .Select(u => u.UserId)
        //    .FirstOrDefaultAsync();
        //var branchName= await context.Users.Where(x=>x.Id = userid)



        //return branchName;
        public async Task<List<ApprovalDetailDto>> GetmainBranchApprovalsAsync(string? term)
        {
            using var context = CreateContext();

            return await context.Approvals
     .Where(x => x.OnlineBCode.StartsWith(term + ".") && x.RequestSource == "Online"
         && x.OnlineStatus != "C")
     .Select(x => new ApprovalDetailDto
     {
         ApprovalId = x.ApprovalId,
         ApprovalDate = x.ApprovalDate,
         ApStatus = x.ApStatus,
         ApType = x.ApType,
         RequestSource = x.RequestSource,
         Notes = x.Notes,
         MemberId = x.MemberId,
         VendorId = x.VendorId,
     })
     .ToListAsync();



        }

        public async Task<List<ApprovalDetailDto>> GetmainBranch3mApprovalsAsync(string? term)
        {
            using var context = CreateContext();

            var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            var startDate = endDate.AddMonths(-3);

            var result= await context.Approvals
                .Where(x => x.OnlineBCode.StartsWith(term + ".")
                         && x.RequestSource == "Online"
                         && x.OnlineStatus == "P"
                         && x.ApprovalDate >= startDate
                         && x.ApprovalDate < endDate)
                .Select(x => new ApprovalDetailDto
                {
                    ApprovalId = x.ApprovalId,
                    ApprovalDate = x.ApprovalDate,
                    ApStatus = x.ApStatus,
                    ApType = x.ApType,
                    RequestSource = x.RequestSource,
                    Notes = x.Notes,
                    MemberId = x.MemberId,
                    MemberName = x.Member.MemberName,
                    CompanyName = context.CustomerContracts.Where(c => c.CustomerContractId == x.ContractId).Select(c => c.CustomerContractCustomer.CustomerName).FirstOrDefault(),
                    v_branch_id=x.OnlineBCode,
                    BranchName = context.OnlineUsers.Where(u => u.Office == x.OnlineBCode).Select(u => u.LastName).FirstOrDefault(),

                    VendorId = x.VendorId,
                })
                .ToListAsync();
            return result;
        }

    }
}