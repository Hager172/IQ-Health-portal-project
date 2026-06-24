using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class RequestcrmCustomerCategory
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public int? CategoriesId { get; set; }

    public int? MinMemberAllow { get; set; }

    public int? AnnualFees { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string? LastUpdatedFrom { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Notes { get; set; }

    public bool? IsLevelIndividual { get; set; }

    public virtual ContractCategory? Categories { get; set; }

    public virtual RequestcrmCustomer Request { get; set; } = null!;
}
