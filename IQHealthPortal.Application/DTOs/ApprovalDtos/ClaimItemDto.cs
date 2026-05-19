using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ClaimItemDto
    {
        public int Id { get; set; }
        public double? Quantity { get; set; }
        public int? Days { get; set; }
        public string Status { get; set; }
        public int? MedItem { get; set; }

        public string? Reason { get; set; }
    }
}
