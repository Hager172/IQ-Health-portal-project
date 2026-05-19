using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerStatusMonitor
{
    public int StatusMonitorId { get; set; }

    public int CustomerMonitorAction { get; set; }

    public string? StatusMonitorStatus { get; set; }

    public string StatusMonitorNewStatus { get; set; } = null!;

    public DateTime StatusMonitorStatusDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;
}
