using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SandaAgentDetail
{
    public int SandaAgentDetailsId { get; set; }

    public string? AgentId { get; set; }

    public int? SandaId { get; set; }

    public DateTime? AgentJoinDate { get; set; }

    public DateTime? AgentEndDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual AspNetUser? Agent { get; set; }

    public virtual Sandum? Sanda { get; set; }
}
