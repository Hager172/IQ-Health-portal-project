using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VServicesAnalysis
{
    public string? StandServiceName { get; set; }

    public string? Category { get; set; }

    public string? ServiceDate { get; set; }

    public string? VendorName { get; set; }

    public string? AreaNameAr { get; set; }

    public string? Gov { get; set; }

    public double? AvgPrice { get; set; }

    public double? MaxPrice { get; set; }

    public double? MinPrice { get; set; }

    public int? ServiceCount { get; set; }

    public decimal BatchId { get; set; }
}
