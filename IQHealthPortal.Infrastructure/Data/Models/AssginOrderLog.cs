using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AssginOrderLog
{
    public int Id { get; set; }

    public int AssginId { get; set; }

    public int Status { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public virtual AssginOrder Assgin { get; set; } = null!;

    public virtual Status StatusNavigation { get; set; } = null!;
}
