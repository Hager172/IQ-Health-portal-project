using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
   public class ApprovalClaimDto
    {
        public long ApprovalId { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string? OnlineBCode { get; set; }

        public string? MemberId { get; set; }

        public string? Notes { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public string? VendorId { get; set; }

        public string? ApStatus { get; set; }

        public string? ApType { get; set; }

        public float Coinsurance { get; set; }

        public string? OnlineUser { get; set; }

        public string? OnlineStatus { get; set; }

        public DateTime OnlineLud { get; set; }

        public string? FormId { get; set; }

        public DateOnly FormDate { get; set; }

        public float MaxValue { get; set; }

        public string? IsOnline { get; set; }

        public string? RequestSource { get; set; }

        public string? CurrentIp { get; set; }
    }
}
