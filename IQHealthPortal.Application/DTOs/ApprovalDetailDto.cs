using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs
{

    public class ApprovalDetailDto
    {
        public long ApprovalId { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApStatus { get; set; }
        public string ApType { get; set; }
        public string RequestSource { get; set; }
        public string Notes { get; set; }
        public string MemberId { get; set; }
        public string MemberName { get; set; }          
        public string MemberNationalId { get; set; }    
        public List<DiagnosisDto> Diagnoses { get; set; } = new();

        public List<ApprovalServiceDto> Services { get; set; } = new();

        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string? v_branch_id { get; set; }
        public string? ContractId { get; set; }
        public long? ParentApproval { get; set; }

        public double? Coinsurance { get; set; }

        public string? IsOnline { get; set; }

        public double? MaxValue { get; set; }

        public string? PrivateNotes { get; set; }
        public string? OnlineStatus { get; set; }

    }
}
