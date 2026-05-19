using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VisitAction
{
    public int Actionid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<VisitLog> VisitLogs { get; set; } = new List<VisitLog>();
}
