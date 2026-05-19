using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SandaScheduleLog
{
    public int ScheduleLog { get; set; }

    public int ScheduleId { get; set; }

    public int StatusId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual SandaSchedule Schedule { get; set; } = null!;

    public virtual StatusProcedure Status { get; set; } = null!;
}
