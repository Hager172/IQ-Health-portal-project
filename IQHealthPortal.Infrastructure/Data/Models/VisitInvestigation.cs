using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VisitInvestigation
{
    public long Id { get; set; }

    public int VisitId { get; set; }

    public DateTime ActDate { get; set; }

    public string ActType { get; set; } = null!;

    public string ActName { get; set; } = null!;

    public string? Note { get; set; }

    public string? FileReport { get; set; }

    public string? FileScanned { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public virtual WafdeenVisit Visit { get; set; } = null!;
}
