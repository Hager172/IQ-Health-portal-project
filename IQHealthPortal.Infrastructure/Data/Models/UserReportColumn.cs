using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserReportColumn
{
    public string UserId { get; set; } = null!;

    public int ReportId { get; set; }

    public string ColumnName { get; set; } = null!;

    public virtual AccReport Report { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
