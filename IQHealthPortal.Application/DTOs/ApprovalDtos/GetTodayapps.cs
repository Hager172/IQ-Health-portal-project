using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class GetTodayapps
    {
        public int? vendor_id { get; set; } 
        public List<ApprovalTodatDTO> Approvals { get; set; }
            = new List<ApprovalTodatDTO>();
    }
}
