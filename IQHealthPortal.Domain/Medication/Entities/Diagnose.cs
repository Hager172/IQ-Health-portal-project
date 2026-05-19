using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Domain.Medication.Entities
{
    public class Diagnose
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public int CareItem { get; set; }
        public int Type { get; set; }
        public Diagnose()
        {
            
        }
    }
}
