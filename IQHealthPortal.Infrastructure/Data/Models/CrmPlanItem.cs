using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmPlanItem
{
    public int Id { get; set; }

    public int PlanId { get; set; }

    public int ItemId { get; set; }

    public string PlanItemPrimaryLevel { get; set; } = null!;

    public string PlanItemPrimaryPaymentType { get; set; } = null!;

    public int PlanItemPrimaryValue { get; set; }

    public int PlanItemPrimaryPeriod { get; set; }

    public string? PlanItemMaxLevel { get; set; }

    public string? PlanItemMaxPaymentType { get; set; }

    public int? PlanItemMaxValue { get; set; }

    public int? PlanItemMaxPeriod { get; set; }

    public string PlanItemCopaymentLevel { get; set; } = null!;

    public string PlanItemCopaymentPaymentType { get; set; } = null!;

    public int PlanItemCopaymentValue { get; set; }

    public string? PlanItemNotes { get; set; }

    public int? PoolsId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public bool Active { get; set; }

    public double MaxValue { get; set; }

    public int? ValidAfter { get; set; }

    public bool? WithApproval { get; set; }

    public bool? NoteAlert { get; set; }

    public virtual ICollection<CrmItemCopayment> CrmItemCopayments { get; set; } = new List<CrmItemCopayment>();

    public virtual ICollection<CrmplanItemRule> CrmplanItemRules { get; set; } = new List<CrmplanItemRule>();

    public virtual CareItem Item { get; set; } = null!;

    public virtual CrmContractPlan Plan { get; set; } = null!;

    public virtual CrmContractPool? Pools { get; set; }
}
