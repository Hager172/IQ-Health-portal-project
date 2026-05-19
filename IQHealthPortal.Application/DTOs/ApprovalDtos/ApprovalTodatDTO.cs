using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ApprovalTodatDTO
    {
      public  long id { get; set; }
        public string note { get; set; }

        public string memberid { get; set; }
        public string membername { get; set; }
        public string apptype { get; set; }

        public DateTime approval_date { get; set; }

    }
}
