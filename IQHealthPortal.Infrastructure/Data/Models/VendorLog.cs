using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorLog
{
    public int LogId { get; set; }

    public int CustomerCode { get; set; }

    public DateTime? ChronicDateTo { get; set; }

    public DateTime? ChronicDateFrom { get; set; }

    public int ActionId { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Note { get; set; }

    public virtual Action Action { get; set; } = null!;

    public virtual Customer CustomerCodeNavigation { get; set; } = null!;
}
