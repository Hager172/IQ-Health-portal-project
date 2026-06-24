using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PharmaPriceLog
{
    public int Id { get; set; }

    public int? PahrmaId { get; set; }

    public string? PriceUpdateId { get; set; }

    public double? OldPrice { get; set; }

    public double? NewPrice { get; set; }

    public int? Active { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string? UrlId { get; set; }

    public string? UrlPrice { get; set; }
}
