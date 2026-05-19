using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Sandum
{
    public int SandaId { get; set; }

    public DateTime? SandaCreatedDate { get; set; }

    public DateTime? SandaEndDate { get; set; }

    public string? MemberId { get; set; }

    public string? SandaNotes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual Member? Member { get; set; }

    public virtual ICollection<SandaAgentDetail> SandaAgentDetails { get; set; } = new List<SandaAgentDetail>();

    public virtual ICollection<SandaSchedule> SandaSchedules { get; set; } = new List<SandaSchedule>();
}
