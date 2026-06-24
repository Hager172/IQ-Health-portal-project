using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BatchesCheckBalance
{
    public decimal BatchId { get; set; }

    public int Serial { get; set; }

    public long InvId { get; set; }

    public string Message { get; set; } = null!;

    public int CustomerId { get; set; }

    public bool IsSolved { get; set; }

    public DateTime? SolvedDate { get; set; }

    public DateTime CheckDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? HasAttach { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual BatchDetail Inv { get; set; } = null!;
}
