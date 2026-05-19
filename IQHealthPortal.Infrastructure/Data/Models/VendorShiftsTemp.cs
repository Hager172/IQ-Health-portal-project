using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorShiftsTemp
{
    public int ShiftId { get; set; }

    public string? VendorId { get; set; }

    public TimeOnly? ShiftStart { get; set; }

    public TimeOnly? ShiftEnd { get; set; }

    public int? ShiftDays { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual DaysOfTheWeek? ShiftDaysNavigation { get; set; }

    public virtual VendorGeneralTemp? Vendor { get; set; }
}
