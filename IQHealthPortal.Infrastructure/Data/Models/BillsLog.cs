using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BillsLog
{
    public int Id { get; set; }

    public int BillId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int Action { get; set; }

    public string? Note { get; set; }

    public int? Serial { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;
}
