using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractCategory
{
    public int ContractCategoriesId { get; set; }

    public string ContractCategoryName { get; set; } = null!;

    public string ContractCategoryNameEn { get; set; } = null!;

    public virtual ICollection<CrmCustomerContractCategory> CrmCustomerContractCategories { get; set; } = new List<CrmCustomerContractCategory>();

    public virtual ICollection<CustomerContractCategory> CustomerContractCategories { get; set; } = new List<CustomerContractCategory>();

    public virtual ICollection<MemberPlan> MemberPlans { get; set; } = new List<MemberPlan>();
}
