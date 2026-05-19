using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ItemCopayment
{
    public string PlanId { get; set; } = null!;

    public int ItemId { get; set; }

    public int VendorCategoryId { get; set; }

    public string? VendorId { get; set; }

    public bool Enabled { get; set; }

    public double Copayment { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public bool? Isallowed { get; set; }

    public virtual PlanItem PlanItem { get; set; } = null!;

    public virtual VendorGeneral? Vendor { get; set; }

    public virtual VendorCategory VendorCategory { get; set; } = null!;
}
