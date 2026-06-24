using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class OnlineUserClient
    {
        
        public string UserId { get; set; } 

        public int ClientId { get; set; } 

      
        public bool IsDefault { get; set; } 

     
        public string VendorId { get; set; } 

        public string? BranchId { get; set; }

        public short? Status { get; set; }
        public string V_Type { get; set; }

        public string? NotHashedPassword { get; set; }


        public ApplicationUser User { get; set; } 

        
        public OnlineClient OnlineClient { get; set; }
    }
}
