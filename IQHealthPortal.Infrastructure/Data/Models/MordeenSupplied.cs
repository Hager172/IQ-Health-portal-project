using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MordeenSupplied
{
    public int Id { get; set; }

    public decimal BatchId { get; set; }

    public string MowredId { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual Batch Batch { get; set; } = null!;
}
