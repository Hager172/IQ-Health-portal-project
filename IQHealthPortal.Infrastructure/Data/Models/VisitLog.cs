using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VisitLog
{
    public int Id { get; set; }

    public int Visitid { get; set; }

    public string? Note { get; set; }

    public int Actionid { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual VisitAction Action { get; set; } = null!;
}
