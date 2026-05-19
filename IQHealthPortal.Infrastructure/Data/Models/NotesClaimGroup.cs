using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class NotesClaimGroup
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime GroupStart { get; set; }

    public DateTime? GroupEnd { get; set; }

    public string StartBy { get; set; } = null!;

    public DateTime StartAt { get; set; }

    public string? EndBy { get; set; }

    public DateTime? EndAt { get; set; }

    public double? FactorUsd { get; set; }

    public double? FactorAed { get; set; }

    public double? AdminFees { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
