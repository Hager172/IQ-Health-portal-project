using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetVendorService
{
    public string? VendorName { get; set; }

    public string? Gov { get; set; }

    public string Area { get; set; } = null!;

    public string? Cat { get; set; }

    public int? ServiceNo { get; set; }

    public string VendorStatus { get; set; } = null!;
}
