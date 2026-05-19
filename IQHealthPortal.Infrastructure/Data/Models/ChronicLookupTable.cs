using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ChronicLookupTable
{
    public string PlanCode { get; set; } = null!;

    public int OldMeditem { get; set; }

    public int? NewMeditem { get; set; }

    public string RefCode { get; set; } = null!;

    public virtual CareItem OldMeditemNavigation { get; set; } = null!;
}
