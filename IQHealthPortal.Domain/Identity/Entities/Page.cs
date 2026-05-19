using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class Page
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? PageParentId { get; set; } 
        public string Type { get; set; } 
        public string Link { get; set; } 
        public string Icon { get; set; } 
        public string Route { get; set; } 

        public Page ParentPage { get; set; } 
        public ICollection<Page> SubPages { get; set; } 
    }
}
