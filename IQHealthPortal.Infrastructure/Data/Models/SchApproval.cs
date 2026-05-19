using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SchApproval
{
    public long TempId { get; set; }

    public string MemberId { get; set; } = null!;

    public string? Notes { get; set; }

    public string? PrivateNotes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public double MaxValue { get; set; }

    public string? FormId { get; set; }

    public string PlanCode { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual ContractPlan PlanCodeNavigation { get; set; } = null!;

    public virtual ICollection<SchApprovalService> SchApprovalServices { get; set; } = new List<SchApprovalService>();

    public virtual ICollection<SchApprovalsArchive> SchApprovalsArchives { get; set; } = new List<SchApprovalsArchive>();

    public virtual ICollection<SchApprovalsLog> SchApprovalsLogs { get; set; } = new List<SchApprovalsLog>();

    public virtual ICollection<OnlineDiagnosis> Diagnoses { get; set; } = new List<OnlineDiagnosis>();
}
