using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.VendorDtos
    {
    public class VendorWithServicesDto
        {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public int VendorCategoryId { get; set; }

        public List<VendorServiceDto> Services { get; set; }
            = new List<VendorServiceDto>();
        }
    }
