using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class DaysOfTheWeek
{
    public int DayId { get; set; }

    public string? DayName { get; set; }

    public string? DayNameAr { get; set; }

    public virtual ICollection<VendorShift> VendorShifts { get; set; } = new List<VendorShift>();

    public virtual ICollection<VendorShiftsTemp> VendorShiftsTemps { get; set; } = new List<VendorShiftsTemp>();
}
