using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.VendorDtos
{
    public class VendorServiceDto
    {
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }

        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Copayment { get; set; }
    }
}
