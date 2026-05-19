using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InsuranceCategoryCode
{
    public int InsuranceCompany { get; set; }

    public int VendorCategoryId { get; set; }

    public int InsuranceCode { get; set; }

    public virtual InsuranceCategory InsuranceCodeNavigation { get; set; } = null!;

    public virtual Customer InsuranceCompanyNavigation { get; set; } = null!;

    public virtual VendorCategory VendorCategory { get; set; } = null!;
}
