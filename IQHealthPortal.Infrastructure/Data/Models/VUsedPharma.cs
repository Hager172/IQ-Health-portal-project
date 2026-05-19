using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VUsedPharma
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double Price { get; set; }

    public string? Notes { get; set; }

    public string? PriceUpdateId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string Availability { get; set; } = null!;

    public string? Source { get; set; }

    public string? UnitSale { get; set; }

    public int? SubUnitNo { get; set; }

    public double? DoseUnitNo { get; set; }

    public string? DoseForm { get; set; }

    public int Active { get; set; }

    public DateTime? LastPriceDate { get; set; }

    public bool? Type { get; set; }
}
