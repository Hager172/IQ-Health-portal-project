using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ClaimServiceDto
    {
        public int ProductId { get; set; }

        public float Qty { get; set; }

        public float Price { get; set; }

        public int Units { get; set; }

        public int Rep { get; set; }

        public int Duration { get; set; }
    }
}
