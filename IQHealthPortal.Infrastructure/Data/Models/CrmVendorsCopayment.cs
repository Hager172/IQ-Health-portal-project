using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmVendorsCopayment
{
    public int Id { get; set; }

    public int PlanItemId { get; set; }

    public string VendorId { get; set; } = null!;

    public int? VendorCategoryId { get; set; }

    public bool Enabled { get; set; }

    public double Copayment { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public bool? Isallowed { get; set; }

    public virtual CrmPlanItem PlanItem { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual VendorCategory? VendorCategory { get; set; }
}
