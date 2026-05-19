using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.itemsDtos
{
    public class OnlineServiceItemDto
    {
        public int? Id { get; set; } 

        public string? Name { get; set; }

        public double? Price { get; set; }

        public double? Quantity { get; set; }

        public bool IsOneUnit { get; set; }

        public string? Status { get; set; }

        public string? Reason { get; set; }

        public int? Days { get; set; }

        public int? MedItem { get; set; }

        public string Covered { get; set; }
    }
}
