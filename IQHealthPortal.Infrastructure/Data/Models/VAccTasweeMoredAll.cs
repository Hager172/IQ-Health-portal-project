using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAccTasweeMoredAll
{
    public decimal AdjNo { get; set; }

    public decimal? AdjNo1 { get; set; }

    public DateTime AdjDate { get; set; }

    public string AdjStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Source { get; set; }

    public string? Omla { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public decimal? SarfWay { get; set; }

    public double? Price { get; set; }
}
