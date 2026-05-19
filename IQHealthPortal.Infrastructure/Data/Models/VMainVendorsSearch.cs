using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMainVendorsSearch
{
    public string VendorId { get; set; } = null!;

    public string? VendorAddress { get; set; }

    public int VendorCategoryId { get; set; }

    public string? VendorFax { get; set; }

    public string VendorStatus { get; set; } = null!;

    public DateTime VendorCreationDate { get; set; }

    public string? VendorMapUrl { get; set; }

    public string? VendorName { get; set; }

    public int VendorClientId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? VendorStatusDate { get; set; }

    public int? VendorArea { get; set; }

    public string? VendorTele { get; set; }

    public string? VendorTele1 { get; set; }

    public string? VendorTele2 { get; set; }

    public decimal? VendorLongitude { get; set; }

    public decimal? VendorLatitude { get; set; }

    public string? VendorContractExecutor { get; set; }

    public string? VendorTaxFile { get; set; }

    public string? VendorCommercialRecord { get; set; }

    public string? VendorTaxId { get; set; }

    public bool? VendorTax { get; set; }

    public int? VendorPayPeriod { get; set; }

    public string? VendorTaxArea { get; set; }

    public string? VendorCheckBeneficiary { get; set; }

    public string? VendorEmail { get; set; }

    public string OldId { get; set; } = null!;

    public bool? HasEta { get; set; }

    public DateOnly? EtaStart { get; set; }

    public bool? IsHosting { get; set; }

    public int? SubCatCode { get; set; }

    public string? SubCatName { get; set; }

    public int CatCode { get; set; }

    public string CatName { get; set; } = null!;

    public string AreaNameAr { get; set; } = null!;

    public int Gov { get; set; }

    public bool VendorCarecard { get; set; }

    public string? VendorCarecardNotes { get; set; }
}
