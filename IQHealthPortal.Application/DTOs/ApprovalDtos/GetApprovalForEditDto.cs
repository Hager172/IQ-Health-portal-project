using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
    {
    public class GetApprovalForEditDto
        {
        public string ApprovalNumber { get; set; } = null!;
        public decimal? Limit { get; set; }
        public decimal? CopaymentPercentage { get; set; }
        public decimal? ExtraCopaymentPercentage { get; set; }
        public List<ApprovalItemDto> Items { get; set; }
        }
    }
