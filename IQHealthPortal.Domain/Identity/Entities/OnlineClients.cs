//using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class OnlineClient
    {
      
        public int ClientId { get; set; } 

        public string ClientName { get; set; } 

        public string ConnectionString { get; set; }


        public byte IsActive { get; set; }

        public ICollection<OnlineUserClient> OnlineUserClients { get; set; }



    }
}
