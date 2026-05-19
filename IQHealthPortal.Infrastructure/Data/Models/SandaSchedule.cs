using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SandaSchedule
{
    public int SandaScheduleId { get; set; }

    public int? SandaId { get; set; }

    public string? AgentId { get; set; }

    public DateTime? ScheduleDateTime { get; set; }

    public string? SandaScheduleNotes { get; set; }

    public string? SandaScheduleDesc { get; set; }

    public int? ScheduleId { get; set; }

    public int? StatusId { get; set; }

    public string ContractId { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual AspNetUser? Agent { get; set; }

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual ICollection<SandaSchedule> InverseSchedule { get; set; } = new List<SandaSchedule>();

    public virtual Sandum? Sanda { get; set; }

    public virtual ICollection<SandaScheduleLog> SandaScheduleLogs { get; set; } = new List<SandaScheduleLog>();

    public virtual SandaSchedule? Schedule { get; set; }

    public virtual StatusProcedure? Status { get; set; }
}
