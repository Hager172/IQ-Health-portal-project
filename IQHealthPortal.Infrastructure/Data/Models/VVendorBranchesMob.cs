using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorBranchesMob
{
    public long VendorBranchSerial { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorBranchName { get; set; }

    public int VendorBranchareaId { get; set; }

    public string? VendorBranchAddress { get; set; }

    public string? VendorBranchTele { get; set; }

    public string? VendorBranchTele2 { get; set; }

    public string VendorBranchStatus { get; set; } = null!;

    public DateTime? VendorBranchDate { get; set; }

    public string? VendorBranchMapUrl { get; set; }

    public decimal? VendorBranchLongitude { get; set; }

    public decimal? VendorBranchLatitude { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int HeadOffice { get; set; }

    public string? VendorEmail { get; set; }

    public string VendorName { get; set; } = null!;

    public int SubCatCode { get; set; }

    public string SubCatName { get; set; } = null!;

    public int CatCode { get; set; }

    public string CatName { get; set; } = null!;

    public string AreaNameAr { get; set; } = null!;

    public int Gov { get; set; }

    public bool VendorCarecard { get; set; }

    public string? VendorCarecardNotes { get; set; }
}
