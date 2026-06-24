using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PlanSharedItem
{
    public long Id { get; set; }

    public string PlanId { get; set; } = null!;

    public int SharedItemId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool IsActive { get; set; }

    public virtual ContractPlan Plan { get; set; } = null!;

    public virtual ICollection<PlanItem> PlanItems { get; set; } = new List<PlanItem>();

    public virtual ICollection<PlanSharedItemRule> PlanSharedItemRules { get; set; } = new List<PlanSharedItemRule>();

    public virtual SharedCareItem SharedItem { get; set; } = null!;
}
