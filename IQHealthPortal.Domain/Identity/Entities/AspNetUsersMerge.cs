using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class AspNetUsersMerge
    {
        public string UserId { get; set; }
        public string UserId1 { get; set; }

        public ApplicationUser User { get; set; }
        public ApplicationUser User1 { get; set; }
    }
}
