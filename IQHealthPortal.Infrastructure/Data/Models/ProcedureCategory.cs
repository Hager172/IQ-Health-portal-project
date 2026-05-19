using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ProcedureCategory
{
    public int ProcId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<VisitProcedure> VisitProcedures { get; set; } = new List<VisitProcedure>();
}
