using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmContractPool
{
    public int Id { get; set; }

    public string? ContractPoolsId { get; set; }

    public int ContractId { get; set; }

    public int? ContractPoolsPoolValue { get; set; }

    public string? ContractPoolsLabel { get; set; }

    public string? ContractPoolsNotes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? AddToCeilling { get; set; }

    public virtual CrmCustomerContract Contract { get; set; } = null!;

    public virtual ICollection<CrmPlanItem> CrmPlanItems { get; set; } = new List<CrmPlanItem>();
}
