using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PlanItem
{
    public string PlanId { get; set; } = null!;

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

    public string? PlanItemPoolId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public bool Active { get; set; }

    public double MaxValue { get; set; }

    public int? ValidAfter { get; set; }

    public bool? WithApproval { get; set; }

    public bool? NoteAlert { get; set; }

    public virtual CareItem Item { get; set; } = null!;

    public virtual ICollection<ItemCopayment> ItemCopayments { get; set; } = new List<ItemCopayment>();

    public virtual ContractPlan Plan { get; set; } = null!;

    public virtual ICollection<PlanItemDiagnosis> PlanItemDiagnoses { get; set; } = new List<PlanItemDiagnosis>();

    public virtual ContractPool? PlanItemPool { get; set; }

    public virtual ICollection<PlanItemRule> PlanItemRules { get; set; } = new List<PlanItemRule>();

    public virtual ICollection<VendorsCopayment> VendorsCopayments { get; set; } = new List<VendorsCopayment>();

    public virtual ICollection<StandardService> Services { get; set; } = new List<StandardService>();
}
