using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractPool
{
    public string ContractPoolsId { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public int? ContractPoolsPoolValue { get; set; }

    public string? ContractPoolsLabel { get; set; }

    public string? ContractPoolsNotes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? AddToCeilling { get; set; }

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual ICollection<PlanItem> PlanItems { get; set; } = new List<PlanItem>();
}
