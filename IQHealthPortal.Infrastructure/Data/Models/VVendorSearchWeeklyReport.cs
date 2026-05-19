using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorSearchWeeklyReport
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public string? Gov { get; set; }

    public string City { get; set; } = null!;

    public string? Address { get; set; }

    public string Phones { get; set; } = null!;
}
