using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ApprovalLogDto
    {
        public long ApprovalId { get; set; }

        public int NumServices { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string? MemberId { get; set; }

        public string? Notes { get; set; }

        public string? ApprovalStatus { get; set; }

        public double? Price { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public int Action { get; set; }
    }
}
