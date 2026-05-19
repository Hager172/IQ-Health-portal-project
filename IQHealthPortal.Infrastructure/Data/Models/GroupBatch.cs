using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class GroupBatch
{
    public decimal BatchId { get; set; }

    public int GroupId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public DateOnly ChequeDate { get; set; }

    public short Type { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual BatchGroup Group { get; set; } = null!;
}
