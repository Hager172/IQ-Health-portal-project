using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerContractCategory
{
    public int ContractCategoryId { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public int? AnnualFees { get; set; }

    public bool? IsLevelIndividual { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedFrom { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public int? MinMemberAllow { get; set; }

    public virtual ContractCategory ContractCategory { get; set; } = null!;

    public virtual CustomerContract CustomerContract { get; set; } = null!;
}
