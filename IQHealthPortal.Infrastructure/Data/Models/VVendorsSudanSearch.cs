using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorsSudanSearch
{
    public string Parent { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Long { get; set; }

    public decimal? Lat { get; set; }

    public int? Cat { get; set; }

    public int? SubCat { get; set; }

    public bool? VipFlag { get; set; }

    public string? Spec { get; set; }

    public int? ConsultSpe { get; set; }

    public int? ConsultExp { get; set; }

    public string VendorId { get; set; } = null!;
}
