using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ClaimLog
{
    public int Id { get; set; }

    public string Note { get; set; } = null!;

    public int CodeId { get; set; }

    public int TypeId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual Action Type { get; set; } = null!;
}
