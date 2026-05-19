using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmCustomerContractCategory
{
    public int Id { get; set; }

    public int? CrmContractId { get; set; }

    public int? CategoriesId { get; set; }

    public int? MinMemberAllow { get; set; }

    public int? AnnualFees { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string? LastUpdatedFrom { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Notes { get; set; }

    public bool? IsLevelIndividual { get; set; }

    public virtual ContractCategory? Categories { get; set; }

    public virtual CrmCustomerContract? CrmContract { get; set; }
}
