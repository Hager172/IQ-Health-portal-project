using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorsSearch
{
    public string Parent { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string Phones { get; set; } = null!;

    public decimal? Long { get; set; }

    public decimal? Lat { get; set; }

    public string? MapLink { get; set; }

    public int? Gov { get; set; }

    public int? City { get; set; }

    public int? Cat { get; set; }

    public int? SubCat { get; set; }

    public bool IsCarecard { get; set; }

    public string? CarecardText { get; set; }

    public bool? VipFlag { get; set; }

    public string? CityName { get; set; }

    public string? Spec { get; set; }

    public int? ConsultSpe { get; set; }

    public int? ConsultExp { get; set; }

    public string? Class { get; set; }

    public bool VendorNbe { get; set; }

    public string VendorId { get; set; } = null!;

    public long BranchId { get; set; }

    public int HeadOffice { get; set; }
}
