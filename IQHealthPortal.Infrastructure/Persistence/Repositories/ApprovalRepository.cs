using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Identity.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class ApprovalRepository : IApprovalRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConnectionStringProvider _connectionStringProvider;
   
        public ApprovalRepository(ApplicationDbContext context, IConnectionStringProvider connectionStringProvider)
        {
            _context = context;

            _connectionStringProvider = connectionStringProvider;
            
        }
        public ApplicationDbContext CreateContext()
        {
            var connection =
                _connectionStringProvider.GetCurrentConnectionString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connection)
                .Options;

            return new ApplicationDbContext(options);
        }
        //public async Task<List<MemberApprovalListDto>> GetByMemberIdAsync(string memberId)
        //{
        //    return await _context.Approvals
        //        .Where(a => a.MemberId == memberId && a.ApStatus == "D" && a.OnlineStatus == "n")
        //        .OrderByDescending(a => a.ApprovalDate)
        //        .Select(a => new MemberApprovalListDto
        //        {
        //            ApprovalNumber = a.ApprovalId,
        //            ApprovalDate = a.ApprovalDate,
        //            Status = a.ApStatus,
        //            Notes = a.Notes,
        //            ExpiryDate = a.ApprovalDate.AddDays(7),
        //            Coinsurance = a.Coinsurance,
        //            MaxValue = a.MaxValue,

        //            ItemCount = a.ApprovalServices.Count(),

        //            Items = a.ApprovalServices.Select(s => new ApprovalItemDto
        //            {
        //                Id = s.ItemSerial.ToString(),
        //                Description = s.ItemDesc,
        //                Quantity = s.Qty ?? 0,
        //                UnitPrice = s.Price ?? 0
        //            }).ToList()
        //        })
        //        .ToListAsync();
        //}

        public async Task<List<MemberApprovalListDto>> GetByMemberIdAsync(string memberId)
        {
            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.MemberId == memberId);

            if (member == null)
            {
                throw new Exception("Member does not exist");
            }

            if (member.MemberStatues != "A")
            {
                throw new Exception("Member is inactive");
            }

            var approvals = await _context.Approvals
                .Where(a => a.MemberId == memberId &&
                            a.ApStatus == "D" &&
                            a.OnlineStatus == "n")
                .OrderByDescending(a => a.ApprovalDate)
                .Select(a => new MemberApprovalListDto
                {
                    ApprovalNumber = a.ApprovalId,
                    ApprovalDate = a.ApprovalDate,
                    Status = a.ApStatus,
                    Notes = a.Notes,
                    ExpiryDate = a.ApprovalDate.AddDays(7),
                    Coinsurance = a.Coinsurance,
                    MaxValue = a.MaxValue,
                    MemberTele=a.Member.MemberTele,
                    ItemCount = a.ApprovalServices.Count(),

                    Items = a.ApprovalServices.Select(s => new ApprovalItemDto
                    {
                        Id = s.ItemSerial.ToString(),
                        Description = s.ItemDesc,
                        Quantity = s.Qty ?? 0,
                        UnitPrice = s.Price ?? 0
                    }).ToList()
                })
                .ToListAsync();

            if (!approvals.Any())
            {
                throw new Exception("No approvals found");
            }

            return approvals;
        }
        public async Task<GetApprovalForEditDto?> GetApprovalForEditAsync(string approvalNumber)
        {
            return await _context.Approvals
                .Where(a => a.FormId == approvalNumber)
                .Select(a => new GetApprovalForEditDto
                {
                    ApprovalNumber = a.FormId!,
                    Limit = (decimal?)a.MaxValue,
                    CopaymentPercentage = (decimal?)a.Coinsurance,
                    ExtraCopaymentPercentage = 0,
                    Items = a.ApprovalServices.Select(s => new ApprovalItemDto
                    {
                        Id = s.ServiceId.ToString(),
                        //Description = s.ServiceName,
                        //Quantity = s.Quantity ?? 1,
                        //QuantityUnit = "Unit",
                        //UnitPrice = (decimal)s.ServicePrice
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }

        public async Task UpdateApprovalItemsAsync(
            string approvalNumber,
            List<ApprovalItemDto> items)
        {
            var approval = await _context.Approvals
                .Include(a => a.ApprovalServices)
                .FirstOrDefaultAsync(a => a.FormId == approvalNumber);

            if (approval == null)
                throw new Exception("Approval not found");

            _context.ApprovalServices.RemoveRange(approval.ApprovalServices);

            approval.ApprovalServices = items.Select((i, index) =>
                new ApprovalService
                {
                    ApprovalId = approval.ApprovalId,
                    ItemSerial = index + 1,
                    ItemDesc = i.Description,
                    Qty = i.Quantity,
                    Price = (double?)i.UnitPrice,
                    OriginalPrice = (double?)i.UnitPrice,
                    LastUpdateDate = DateTime.Now,
                    LastUpdateFrom = "API"
                }).ToList();
        }

        public async Task<ApprovalDetailDto?> GetApprovalDetailDtoAsync(long approvalId)
        {
            var connectionString = _connectionStringProvider.GetDefaultConnectionString();
            var approvalDto = new ApprovalDetailDto();

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = @"
                    SELECT 
                        a.approval_id AS ApprovalId,
                        a.approval_date AS ApprovalDate,
                        a.ap_status AS ApStatus,
                        a.ap_type AS ApType,
                        a.request_source AS RequestSource,
                        a.v_branch_id,
                        a.notes AS Notes,
                        a.member_id AS MemberId,
                        a.vendor_id AS VendorId,
                        m.member_name AS MemberName,
                        m.member_national_id AS MemberNationalId,
                        v.vendor_name AS VendorName,
                        a.max_value,
                        a.is_online,
                        a.coinsurance,
                        a.parent_approval,
                        a.private_notes as privateNotes,
                        a.contract_id,
                        a.online_status
                    FROM approvals a
                    LEFT JOIN Members m ON a.member_id = m.member_id
                    LEFT JOIN Vendor_General v ON a.vendor_id = v.vendor_id
                    WHERE a.approval_id = @ApprovalId AND a.online_status= 'N'; 
                    SELECT 
                        d.Id,
                        d.name,
                        d.Category,
                        d.care_item,
                        d.Type,
                        oc.name as onlineName
                    FROM online_diagnosis d
                    INNER JOIN approval_diagnose ad ON d.Id = ad.diagnose_id
                    left join online_Item_categories oc on oc.Id=d.care_item
                    WHERE ad.approval_id = @ApprovalId;
                   SELECT 
                        s.approval_id,
                        s.item_serial,
                        s.service_id,
                        s.med_item,
                        s.qty,
                        s.price,
                        c.care_item_name,
                        s.Notes,
	                    s.is_actual_value,
	                    s.original_price,
	                    s.min_units,
	                    s.dose_units,
	                    s.dose_repeat,
	                    s.dose_duration,
	                    s.ap_qty,
	                    s.editqty,
	                    s.dose_dur_type,
	                    s.coinsurance,
	                    s.is_chronic,
                    s.item_repeat,
                    s.days,
                    s.online_status,
                    s.item_desc,
                    s.original_price,
                    s.insurer_meditem
                    FROM approval_services s
                    Left Join care_items c on c.care_item_code=s.med_item
                    WHERE s.approval_id = @ApprovalId
                    ORDER BY item_serial;";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApprovalId", approvalId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            approvalDto.ApprovalId = reader.GetInt64(reader.GetOrdinal("ApprovalId"));
                            approvalDto.ApprovalDate = reader.GetDateTime(reader.GetOrdinal("ApprovalDate"));
                            approvalDto.ApStatus = reader.IsDBNull(reader.GetOrdinal("ApStatus")) ? null : reader.GetString(reader.GetOrdinal("ApStatus"));
                            approvalDto.ApType = reader.IsDBNull(reader.GetOrdinal("ApType")) ? null : reader.GetString(reader.GetOrdinal("ApType"));
                            approvalDto.RequestSource = reader.IsDBNull(reader.GetOrdinal("RequestSource")) ? null : reader.GetString(reader.GetOrdinal("RequestSource"));
                            approvalDto.Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
                            approvalDto.MemberId = reader.IsDBNull(reader.GetOrdinal("MemberId")) ? null : reader.GetString(reader.GetOrdinal("MemberId"));
                            approvalDto.MemberName = reader.IsDBNull(reader.GetOrdinal("MemberName")) ? null : reader.GetString(reader.GetOrdinal("MemberName"));
                            approvalDto.MemberNationalId = reader.IsDBNull(reader.GetOrdinal("MemberNationalId")) ? null : reader.GetString(reader.GetOrdinal("MemberNationalId"));
                            approvalDto.VendorId = reader.IsDBNull(reader.GetOrdinal("VendorId")) ? null : reader.GetString(reader.GetOrdinal("VendorId"));
                            approvalDto.VendorName = reader.IsDBNull(reader.GetOrdinal("VendorName")) ? null : reader.GetString(reader.GetOrdinal("VendorName"));
                            approvalDto.v_branch_id = reader.IsDBNull(reader.GetOrdinal("v_branch_id")) ? null : reader.GetString(reader.GetOrdinal("v_branch_id"));
                            approvalDto.PrivateNotes = reader.IsDBNull(reader.GetOrdinal("privateNotes")) ? null : reader.GetString(reader.GetOrdinal("privateNotes"));
                            approvalDto.MaxValue = reader.IsDBNull(reader.GetOrdinal("max_value")) ? null : reader.GetDouble(reader.GetOrdinal("max_value"));
                            approvalDto.IsOnline = reader.IsDBNull(reader.GetOrdinal("is_online")) ? null : reader.GetString(reader.GetOrdinal("is_online"));
                            approvalDto.ContractId = reader.IsDBNull(reader.GetOrdinal("contract_id")) ? null : reader.GetString(reader.GetOrdinal("contract_id"));
                            approvalDto.Coinsurance = reader.IsDBNull(reader.GetOrdinal("coinsurance")) ? null : reader.GetDouble(reader.GetOrdinal("coinsurance"));
                            approvalDto.ParentApproval = reader.IsDBNull(reader.GetOrdinal("parent_approval")) ? null : reader.GetInt32(reader.GetOrdinal("parent_approval"));
                            approvalDto.OnlineStatus = reader.IsDBNull(reader.GetOrdinal("online_status")) ? null : reader.GetString(reader.GetOrdinal("online_status"));



                        }
                        else
                        {
                            return null;
                        }
                        approvalDto.Diagnoses = new List<DiagnosisDto>();
                        approvalDto.Services = new List<ApprovalServiceDto>();
                        if (await reader.NextResultAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var diagnosis = new DiagnosisDto
                                {
                                    Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? null : reader.GetString(reader.GetOrdinal("Id")),
                                    Name = reader.IsDBNull(reader.GetOrdinal("name"))
                                        ? (reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString(reader.GetOrdinal("name")))
                                        : reader.GetString(reader.GetOrdinal("name")),
                                    onlineName = reader.IsDBNull(reader.GetOrdinal("onlineName"))
                                        ? (reader.IsDBNull(reader.GetOrdinal("onlineName")) ? null : reader.GetString(reader.GetOrdinal("onlineName")))
                                        : reader.GetString(reader.GetOrdinal("onlineName")),
                                    Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? 0 : reader.GetInt32(reader.GetOrdinal("Category")),
                                    CareItem = reader.IsDBNull(reader.GetOrdinal("care_item")) ? 0 : reader.GetInt32(reader.GetOrdinal("care_item")),
                                    Type = reader.IsDBNull(reader.GetOrdinal("Type")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Type"))
                                };
                                approvalDto.Diagnoses.Add(diagnosis);
                            }
                        }
                        if (await reader.NextResultAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var service = new ApprovalServiceDto
                                {
                                    ApprovalId = approvalId,
                                    ItemSerial = reader.GetInt32(reader.GetOrdinal("item_serial")),
                                    ServiceId = reader.GetInt32(reader.GetOrdinal("service_id")),
                                    MedItem = reader.IsDBNull(reader.GetOrdinal("med_item")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("med_item")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                    CareItemName = reader.IsDBNull(reader.GetOrdinal("care_item_name")) ? null : reader.GetString(reader.GetOrdinal("care_item_name")),
                                    Qty = reader.IsDBNull(reader.GetOrdinal("qty")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("qty")),
                                    Price = reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("price")),
                                    ItemDesc = reader.IsDBNull(reader.GetOrdinal("item_desc")) ? null : reader.GetString(reader.GetOrdinal("item_desc")),
                                    IsChronic = reader.IsDBNull(reader.GetOrdinal("is_chronic")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("is_chronic")),
                                    ItemRepeat = reader.IsDBNull(reader.GetOrdinal("item_repeat")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("item_repeat")),
                                    InsurerMeditem = reader.IsDBNull(reader.GetOrdinal("insurer_meditem")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("insurer_meditem")),
                                    Coinsurance = reader.IsDBNull(reader.GetOrdinal("coinsurance")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("coinsurance")),
                                    OnlineStatus = reader.IsDBNull(reader.GetOrdinal("online_status")) ? null : reader.GetString(reader.GetOrdinal("online_status")),
                                    ApQty = reader.IsDBNull(reader.GetOrdinal("ap_qty")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("ap_qty")),
                                    Days = reader.IsDBNull(reader.GetOrdinal("days")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("days")),
                                    DoseDurType = reader.IsDBNull(reader.GetOrdinal("dose_dur_type")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("dose_dur_type")),
                                    MinUnits = reader.IsDBNull(reader.GetOrdinal("min_units")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("min_units")),
                                    DoseUnits = reader.IsDBNull(reader.GetOrdinal("dose_units")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("dose_units")),
                                    DoseRepeat = reader.IsDBNull(reader.GetOrdinal("dose_repeat")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("dose_repeat")),
                                    DoseDuration = reader.IsDBNull(reader.GetOrdinal("dose_duration")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("dose_duration")),
                                    OriginalPrice = reader.IsDBNull(reader.GetOrdinal("original_price")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("original_price")),
                                    Editqty = reader.IsDBNull(reader.GetOrdinal("editqty")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("editqty")),
                                    IsActualValue = reader.IsDBNull(reader.GetOrdinal("is_actual_value")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("is_actual_value"))
                                };
                                approvalDto.Services.Add(service);
                            }
                        }
                    }
                }
            }

            return approvalDto;
        }


        //public async Task<List<ApprovalTodatDTO>> GetAllTodayApprovals(string vendor_id)

        //{
        //    return _context.Approvals.Where(a => a.VendorId == vendor_id && a.OnlineStatus == "p" && a.ApStatus == "d" && a.ApprovalDate >= DateTime.Now.AddHours(-24)).Select(m => new ApprovalTodatDTO
        //    {
        //        id = m.ApprovalId,
        //        approval_date = m.ApprovalDate,
        //        memberid = m.MemberId,
        //        membername = m.Member.MemberName,
        //        apptype = m.ApType,
        //        note = m.Notes

        //    }).ToList();
        //}
        public async Task<List<ApprovalTodatDTO>> GetAllTodayApprovals(string clientid,string VendorId)
        {
            var connectionString = _connectionStringProvider.GetConnectionString(clientid);

            var approvals = new List<ApprovalTodatDTO>();

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = @"
                    SELECT 
                        a.approval_id AS id,
                        a.approval_date,
                        a.member_id AS memberid,
                        m.member_name AS membername,
                        a.ap_type AS apptype,
                        a.notes AS note
                    FROM approvals a
                    LEFT JOIN Members m ON a.member_id = m.member_id
                    WHERE a.vendor_id = @VendorId 
                      AND a.online_status = 'p' 
                      AND a.ap_status = 'd' 
                    AND a.approval_date >= DATEADD(hour, -24, GETDATE())
                    ";
               
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorId", VendorId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            approvals.Add(new ApprovalTodatDTO
                            {
                                id = reader.GetInt64(reader.GetOrdinal("id")),
                                approval_date = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                                memberid = reader.IsDBNull(reader.GetOrdinal("memberid")) ? null : reader.GetString(reader.GetOrdinal("memberid")),
                                membername = reader.IsDBNull(reader.GetOrdinal("membername")) ? null : reader.GetString(reader.GetOrdinal("membername")),
                                apptype = reader.IsDBNull(reader.GetOrdinal("apptype")) ? null : reader.GetString(reader.GetOrdinal("apptype")),
                                note = reader.IsDBNull(reader.GetOrdinal("note")) ? null : reader.GetString(reader.GetOrdinal("note"))
                            });
                        }
                    }
                }
            }
            return approvals;
        }
        //public async Task<List<ApprovalTodatDTO>> Getnotcompeleteapp(string vendor_id)
        //{
        //    return _context.Approvals.Where(a => a.VendorId == vendor_id && a.RequestSource == "Online" && a.OnlineStatus == "N" && a.ApStatus != "d" && a.ApprovalDate >= DateTime.Now.AddHours(-24)).Select(m => new ApprovalTodatDTO
        //    {
        //        id = m.ApprovalId,
        //        approval_date = m.ApprovalDate,
        //        memberid = m.MemberId,
        //        membername = m.Member.MemberName,
        //        apptype = m.ApType,
        //        note = m.Notes


        //    }).ToList();
        //}

        public async Task<List<ApprovalTodatDTO>> Getnotcompeleteapp(string clientid, string VendorId)
        {
            var connectionString = _connectionStringProvider.GetConnectionString(clientid);
            var approvals = new List<ApprovalTodatDTO>();

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = @"
                SELECT 
                    a.approval_id AS id,
                    a.approval_date,
                    a.member_id AS memberid,
                    m.member_name AS membername,
                    a.ap_type AS apptype,
                    a.notes AS note
                FROM approvals a
                LEFT JOIN Members m ON a.member_id = m.member_id
                WHERE a.vendor_id = @VendorId 
                  AND a.request_source = 'Online' 
                  AND a.online_status = 'N' 
                  AND a.ap_status <> 'd' 
                  AND a.approval_date >= DATEADD(hour, -24, GETDATE())";
                //                string query = @"
                //SELECT 
                //    a.approval_id AS id,
                //    a.approval_date,
                //    a.member_id AS memberid,
                //    m.member_name AS membername,
                //    a.ap_type AS apptype,
                //    a.notes AS note
                //FROM approvals a
                //LEFT JOIN Members m ON a.member_id = m.member_id
                //WHERE a.vendor_id = @VendorId 
                //  AND a.online_status = 'p' 
                //  AND a.ap_status = 'd'
                //  AND CAST(a.approval_date AS DATE) = CAST(GETDATE() AS DATE)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorId", VendorId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            approvals.Add(new ApprovalTodatDTO
                            {
                                id = reader.GetInt64(reader.GetOrdinal("id")),
                                approval_date = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                                memberid = reader.IsDBNull(reader.GetOrdinal("memberid")) ? null : reader.GetString(reader.GetOrdinal("memberid")),
                                membername = reader.IsDBNull(reader.GetOrdinal("membername")) ? null : reader.GetString(reader.GetOrdinal("membername")),
                                apptype = reader.IsDBNull(reader.GetOrdinal("apptype")) ? null : reader.GetString(reader.GetOrdinal("apptype")),
                                note = reader.IsDBNull(reader.GetOrdinal("note")) ? null : reader.GetString(reader.GetOrdinal("note"))
                            });
                        }
                    }
                }
            }
            return approvals;
        }


        public async Task AddApprovalAsync(ApprovalClaimDto dto)
        {


            using var context = CreateContext();
            try {             var approval = new Approval
            {
                ApprovalId = dto.ApprovalId,
                ApprovalDate = dto.ApprovalDate,
                OnlineBCode = dto.OnlineBCode,
                MemberId = dto.MemberId,
                Notes = dto.Notes,
                LastUpdateBy = dto.LastUpdateBy,
                LastUpdateDate = dto.LastUpdateDate,
                LastUpdateFrom = dto.LastUpdateFrom,
                VendorId = dto.VendorId,
                ApStatus = dto.ApStatus,
                ApType = dto.ApType,
                Coinsurance = dto.Coinsurance,
                OnlineUser = dto.OnlineUser,
                OnlineStatus = dto.OnlineStatus,
                OnlineLud = dto.OnlineLud,
                FormId = dto.FormId,
                FormDate = dto.FormDate,
                MaxValue = dto.MaxValue,
                IsOnline = dto.IsOnline,
                RequestSource = dto.RequestSource
                ,ReqId= 3

            };

            await context.Approvals.AddAsync(approval);
            await context.SaveChangesAsync();
            }
            catch
            {

            }
        }


    }





}
