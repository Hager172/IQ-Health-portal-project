using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VisitDiagnosis
{
    public string DiagnoseId { get; set; } = null!;

    public int VisitId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual OnlineDiagnosis Diagnose { get; set; } = null!;

    public virtual WafdeenVisit Visit { get; set; } = null!;
}
