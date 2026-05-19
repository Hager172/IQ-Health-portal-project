using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberPlan
{
    public string MemberCode { get; set; } = null!;

    public string PlanCode { get; set; } = null!;

    public int MamberPlanFinancialPlan { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string CardPrinted { get; set; } = null!;

    public string ContractCode { get; set; } = null!;

    public string? Status { get; set; }

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual CustomerContract ContractCodeNavigation { get; set; } = null!;

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ContractCategory MamberPlanFinancialPlanNavigation { get; set; } = null!;

    public virtual Member MemberCodeNavigation { get; set; } = null!;

    public virtual ContractPlan PlanCodeNavigation { get; set; } = null!;
}
