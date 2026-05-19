using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class DueAttachedFile
{
    public int DueAttachedId { get; set; }

    public decimal? BatchId { get; set; }

    public string? DueAttachedName { get; set; }

    public bool? DeleteFlag { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual Batch? Batch { get; set; }
}
