using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Application.ApprovalService.Queries.GetApproval
{
    public class GetApprovalDetailsQuery
    {
        public long ApprovalId { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string? RequestSource { get; set; }

        public string MemberId { get; set; } = null!;

        public string? Notes { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public string VendorId { get; set; } = null!;

        public string? ApStatus { get; set; }

        public string ApType { get; set; } = null!;

        public long? ParentApproval { get; set; }

        public double? Coinsurance { get; set; }

        public string? IsOnline { get; set; }

        public double? MaxValue { get; set; }

        public string? PrivateNotes { get; set; }

        public string? OnlineUser { get; set; }

        public string? OnlineStatus { get; set; }

        public string? OnlineBCode { get; set; }

        public DateTime? OnlineLud { get; set; }

        public string? FormId { get; set; }

        public bool? Isnotified { get; set; }

        public DateOnly? FormDate { get; set; }

        public string? Currentip { get; set; }

        public string? PlanCode { get; set; }

        public long? MainApproval { get; set; }

        public bool? IsExceptional { get; set; }

        public int? ChronicRef { get; set; }

        public bool? HoldOnRev { get; set; }

        public long? VBranchId { get; set; }

        public string? ContractId { get; set; }

        public int? ReqId { get; set; }

    }
}
