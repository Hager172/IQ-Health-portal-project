using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BatchesPrivateNote
{
    public int Id { get; set; }

    public long InvId { get; set; }

    public string PrivateNote { get; set; } = null!;

    public string WrittenBy { get; set; } = null!;

    public DateTime Date { get; set; }

    public int Type { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual BatchDetail Inv { get; set; } = null!;
}
