using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PlanItemDiagnosis
{
    public string PlanId { get; set; } = null!;

    public int ItemId { get; set; }

    public string DiagnoseId { get; set; } = null!;

    public bool Enabled { get; set; }

    public virtual OnlineDiagnosis Diagnose { get; set; } = null!;

    public virtual PlanItem PlanItem { get; set; } = null!;
}
