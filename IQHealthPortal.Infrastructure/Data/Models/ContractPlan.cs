using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractPlan
{
    public string ContractPlanId { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public string? ContractPlanClass { get; set; }

    public string? ContractPlanNotes { get; set; }

    public bool? ContractPlanReimb { get; set; }

    public double ClassCeiling { get; set; }

    public bool? IsDirect { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string? ResidenceId { get; set; }

    public string? ExternalCode { get; set; }

    public int? ResidencePercent { get; set; }

    public string? CeilingLevel { get; set; }

    public string? MedicalNetworkClass { get; set; }

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual ICollection<MemberPlanAuthenticateLog> MemberPlanAuthenticateLogs { get; set; } = new List<MemberPlanAuthenticateLog>();

    public virtual ICollection<MemberPlan> MemberPlans { get; set; } = new List<MemberPlan>();

    public virtual ICollection<PlanItem> PlanItems { get; set; } = new List<PlanItem>();

    public virtual Residence? Residence { get; set; }

    public virtual ICollection<SchApproval> SchApprovals { get; set; } = new List<SchApproval>();
}
