using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PlanSharedItemRule
{
    public string PlanId { get; set; } = null!;

    public int ItemId { get; set; }

    public int RuleSerial { get; set; }

    public double RuleValue { get; set; }

    public string RuleLevel { get; set; } = null!;

    public int RuleCycle { get; set; }

    public string PaymentType { get; set; } = null!;

    public bool IsActive { get; set; }

    public long SharedItemId { get; set; }

    public virtual SharedCareItem Item { get; set; } = null!;

    public virtual ContractPlan Plan { get; set; } = null!;

    public virtual PlanSharedItem SharedItem { get; set; } = null!;
}
