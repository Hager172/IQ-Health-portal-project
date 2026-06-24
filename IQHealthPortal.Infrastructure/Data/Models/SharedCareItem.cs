using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SharedCareItem
{
    public int SharedItemId { get; set; }

    public string? SharedItemName { get; set; }

    public virtual ICollection<PlanSharedItemRule> PlanSharedItemRules { get; set; } = new List<PlanSharedItemRule>();

    public virtual ICollection<PlanSharedItem> PlanSharedItems { get; set; } = new List<PlanSharedItem>();
}
