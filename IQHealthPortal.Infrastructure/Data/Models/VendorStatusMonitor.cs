using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorStatusMonitor
{
    public string StatusMonitorVendorId { get; set; } = null!;

    public int StatusMonitorId { get; set; }

    public long? StatusMonitorBranchId { get; set; }

    public string StatusMonitorStatus { get; set; } = null!;

    public string StatusMonitorNewStatus { get; set; } = null!;

    public DateTime StatusMonitorStatusDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public int? ActionId { get; set; }

    public string? Note { get; set; }

    public virtual Action? Action { get; set; }

    public virtual VendorBranch? StatusMonitorBranch { get; set; }

    public virtual VendorGeneral StatusMonitorVendor { get; set; } = null!;
}
