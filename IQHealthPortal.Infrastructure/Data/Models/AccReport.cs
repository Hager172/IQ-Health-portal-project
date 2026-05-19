using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccReport
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string Script { get; set; } = null!;

    public string? NumericalColumn { get; set; }

    public virtual ICollection<UserReportColumn> UserReportColumns { get; set; } = new List<UserReportColumn>();
}
