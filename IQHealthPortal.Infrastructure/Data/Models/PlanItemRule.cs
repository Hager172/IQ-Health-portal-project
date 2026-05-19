using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PlanItemRule
{
    public string PlanId { get; set; } = null!;

    public int ItemId { get; set; }

    public int RuleSerial { get; set; }

    public double RuleValue { get; set; }

    public string RuleLevel { get; set; } = null!;

    public int RuleCycle { get; set; }

    public string PaymentType { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual PlanItem PlanItem { get; set; } = null!;

    public virtual ICollection<OnlineDiagnosis> Diagnsoes { get; set; } = new List<OnlineDiagnosis>();
}
