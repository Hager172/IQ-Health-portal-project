using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class MemberApprovalListDto
    {
        public long ApprovalNumber { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string? Status { get; set; }

        public string? Notes { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public double? Coinsurance { get; set; }

        public double? MaxValue { get; set; }

        public int ItemCount { get; set; }

        public string? MemberTele { get; set; }

        public List<ApprovalItemDto>? Items { get; set; }
    }
}
