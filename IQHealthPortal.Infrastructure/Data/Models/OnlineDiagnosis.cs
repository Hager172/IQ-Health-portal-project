using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineDiagnosis
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public int Category { get; set; }

    public int CareItem { get; set; }

    public int? Type { get; set; }

    public virtual OnlineItemCategory CareItemNavigation { get; set; } = null!;

    public virtual OnlineDiagnoseCategory CategoryNavigation { get; set; } = null!;

    public virtual ICollection<OnlineDiagnosisMain> OnlineDiagnosisMains { get; set; } = new List<OnlineDiagnosisMain>();

    public virtual ICollection<OnlineMedDiagnose> OnlineMedDiagnoses { get; set; } = new List<OnlineMedDiagnose>();

    public virtual ICollection<PlanItemDiagnosis> PlanItemDiagnoses { get; set; } = new List<PlanItemDiagnosis>();

    public virtual ICollection<VisitDiagnosis> VisitDiagnoses { get; set; } = new List<VisitDiagnosis>();

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<ApprovalsOnline> ApprovalsNavigation { get; set; } = new List<ApprovalsOnline>();

    public virtual ICollection<OnlineRawMaterial> IdRmatrials { get; set; } = new List<OnlineRawMaterial>();

    public virtual ICollection<BatchDetail> Invs { get; set; } = new List<BatchDetail>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public virtual ICollection<PlanItemRule> PlanItemRules { get; set; } = new List<PlanItemRule>();

    public virtual ICollection<SchApproval> Temps { get; set; } = new List<SchApproval>();
}
