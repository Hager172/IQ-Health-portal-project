using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetIsPackageContract
{
    public string? VendorName { get; set; }

    public string VendorId { get; set; } = null!;

    public int ContractServiceId { get; set; }

    public string? ContractServiceName { get; set; }

    public double ContractServicePrices { get; set; }

    public bool? IsPackage { get; set; }
}
