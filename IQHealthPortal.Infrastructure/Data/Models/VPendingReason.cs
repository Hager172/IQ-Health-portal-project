using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VPendingReason
{
    public string? Reason { get; set; }

    public int? Count { get; set; }
}
