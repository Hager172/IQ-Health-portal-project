using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WafdeenMembersSchedule
{
    public int ScheduleId { get; set; }

    public string MemberId { get; set; } = null!;

    public DateOnly TaskDate { get; set; }

    public TimeOnly? TaskTime { get; set; }

    public string? Comment { get; set; }

    public bool? IsDone { get; set; }

    public int? VisitId { get; set; }

    public int? ResponsibleEmp { get; set; }

    public string? VendorId { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string? Status { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual WafdeenMashEmp? ResponsibleEmpNavigation { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }

    public virtual WafdeenVisit? Visit { get; set; }
}
