using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WafdeenRecord
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public string? Text { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? NameRecord { get; set; }

    public virtual WafdeenVisit? Case { get; set; }
}
