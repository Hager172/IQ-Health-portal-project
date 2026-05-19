using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorShift
{
    public int ShiftId { get; set; }

    public string? VendorId { get; set; }

    public TimeOnly? ShiftStart { get; set; }

    public TimeOnly? ShiftEnd { get; set; }

    public int? ShiftDays { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public long? VendorBranchSerial { get; set; }

    public virtual DaysOfTheWeek? ShiftDaysNavigation { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }

    public virtual VendorBranch? VendorBranchSerialNavigation { get; set; }
}
