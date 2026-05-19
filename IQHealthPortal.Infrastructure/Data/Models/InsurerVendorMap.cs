using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InsurerVendorMap
{
    public int Insurer { get; set; }

    public string VendorId { get; set; } = null!;

    public string? LinkId { get; set; }

    public int? VendorCat { get; set; }

    public virtual Customer InsurerNavigation { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
