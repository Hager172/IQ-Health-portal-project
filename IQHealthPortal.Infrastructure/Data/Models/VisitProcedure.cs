using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VisitProcedure
{
    public int Id { get; set; }

    public int ProcId { get; set; }

    public int VisitId { get; set; }

    public DateTime StartProc { get; set; }

    public DateTime? EndProc { get; set; }

    public decimal EstimatedValue { get; set; }

    public decimal? ActuallyValue { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int Status { get; set; }

    public string? VendorName { get; set; }

    public virtual ProcedureCategory Proc { get; set; } = null!;

    public virtual StatusProcedure StatusNavigation { get; set; } = null!;

    public virtual WafdeenVisit Visit { get; set; } = null!;
}
