using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class Privilege
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public string RoleId { get; set; }
        //public bool View { get; set; }
        //public bool Add { get; set; }
        //public bool Edit { get; set; }
        //public bool Submit { get; set; }
        //public bool Unsubmit { get; set; }
        //public bool Cancel { get; set; }
        //public bool Import { get; set; }
        //public bool Export { get; set; }
        //public bool Print { get; set; }
        //public bool Print { get; set; }
        //public bool SpacialCase { get; set; }

        public ApplicationRole Role { get; set; } 
        public Page Page { get; set; }

        public int ClientId { get; set; }
        public OnlineClient Client { get; set; }
    }
}
