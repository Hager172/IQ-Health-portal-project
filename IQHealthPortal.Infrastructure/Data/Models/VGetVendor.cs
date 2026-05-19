using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetVendor
{
    public string? VendorEmail { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public string VendorStatus { get; set; } = null!;

    public string? VendorAddress { get; set; }

    public string? VendorMapUrl { get; set; }

    public string? VendormedcareClass { get; set; }

    public string AreaNameAr { get; set; } = null!;

    public string? Gov { get; set; }

    public string? CatName { get; set; }

    public string? SubName { get; set; }

    public int VendorCategoryId { get; set; }

    public string Phones { get; set; } = null!;

    public int? CatIndex { get; set; }

    public string? VendorCarecardNotes { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public int BdCountlast90 { get; set; }
}
