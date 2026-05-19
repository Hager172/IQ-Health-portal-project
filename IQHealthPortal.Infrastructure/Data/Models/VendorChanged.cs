using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorChanged
{
    public string OldVendor { get; set; } = null!;

    public string NewVendor { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual VendorGeneral NewVendorNavigation { get; set; } = null!;

    public virtual VendorGeneral OldVendorNavigation { get; set; } = null!;
}
