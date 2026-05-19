using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorService
{
    public string VendorId { get; set; } = null!;

    public int VendorCategoryId { get; set; }

    public string? MainCat { get; set; }

    public string? CatName { get; set; }

    public string? Gov { get; set; }

    public string AreaNameAr { get; set; } = null!;

    public string ContractServiceContractCode { get; set; } = null!;

    public string? VendorName { get; set; }

    public int? ServiceNumber { get; set; }

    public int? NotMapped { get; set; }

    public int? Mapped { get; set; }
}
