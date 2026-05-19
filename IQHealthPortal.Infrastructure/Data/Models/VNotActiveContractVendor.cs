using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VNotActiveContractVendor
{
    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public int VendorCategoryId { get; set; }

    public string? Cat { get; set; }
}
