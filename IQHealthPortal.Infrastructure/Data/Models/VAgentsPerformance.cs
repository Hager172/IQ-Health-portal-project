using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAgentsPerformance
{
    public string? Agent { get; set; }

    public int? T1 { get; set; }

    public int? T2 { get; set; }

    public int? T3 { get; set; }
}
