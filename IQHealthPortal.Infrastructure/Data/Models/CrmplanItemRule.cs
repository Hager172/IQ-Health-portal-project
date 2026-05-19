using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmplanItemRule
{
    public int Id { get; set; }

    public int PlanItemId { get; set; }

    public int RuleSerial { get; set; }

    public double RuleValue { get; set; }

    public string RuleLevel { get; set; } = null!;

    public int RuleCycle { get; set; }

    public string PaymentType { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual CrmPlanItem PlanItem { get; set; } = null!;
}
