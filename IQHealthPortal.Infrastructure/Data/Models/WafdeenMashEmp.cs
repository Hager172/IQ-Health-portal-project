using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WafdeenMashEmp
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public bool EmpStatus { get; set; }

    public string? UserId { get; set; }

    public virtual AspNetUser? User { get; set; }

    public virtual ICollection<WafdeenMembersSchedule> WafdeenMembersSchedules { get; set; } = new List<WafdeenMembersSchedule>();

    public virtual ICollection<WafdeenVisit> WafdeenVisits { get; set; } = new List<WafdeenVisit>();
}
