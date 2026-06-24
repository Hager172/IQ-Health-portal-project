using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CheckBalanceBugReport
{
    public long Id { get; set; }

    public decimal BatchId { get; set; }

    public long InvId { get; set; }

    public bool IsSolved { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public bool? Accepted { get; set; }

    public string? AcceptedBy { get; set; }

    public DateTime? AcceptedAt { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual BatchDetail Inv { get; set; } = null!;
}
