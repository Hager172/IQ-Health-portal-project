using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TicketReport
{
    public int ReportId { get; set; }

    public DateTime ReportStartDate { get; set; }

    public DateTime ReportEndDate { get; set; }

    public DateTime ReportDate { get; set; }

    public string? ReportFile { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }
}
