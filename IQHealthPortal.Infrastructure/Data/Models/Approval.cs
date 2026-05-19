using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Approval
{
    public long ApprovalId { get; set; }

    public DateTime ApprovalDate { get; set; }

    public string? RequestSource { get; set; }

    public string MemberId { get; set; } = null!;

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string VendorId { get; set; } = null!;

    public string? ApStatus { get; set; }

    public string ApType { get; set; } = null!;

    public long? ParentApproval { get; set; }

    public double? Coinsurance { get; set; }

    public string? IsOnline { get; set; }

    public double? MaxValue { get; set; }

    public string? PrivateNotes { get; set; }

    public string? OnlineUser { get; set; }

    public string? OnlineStatus { get; set; }

    public string? OnlineBCode { get; set; }

    public DateTime? OnlineLud { get; set; }

    public string? FormId { get; set; }

    public bool? Isnotified { get; set; }

    public DateOnly? FormDate { get; set; }

    public string? Currentip { get; set; }

    public string? PlanCode { get; set; }

    public long? MainApproval { get; set; }

    public bool? IsExceptional { get; set; }

    public int? ChronicRef { get; set; }

    public bool? HoldOnRev { get; set; }

    public long? VBranchId { get; set; }

    public string? ContractId { get; set; }

    public int? ReqId { get; set; }

    public int? ApprovalProcessingTime { get; set; }

    public virtual ICollection<ApprovalChatSeen> ApprovalChatSeens { get; set; } = new List<ApprovalChatSeen>();

    public virtual ICollection<ApprovalFollowUp> ApprovalFollowUps { get; set; } = new List<ApprovalFollowUp>();

    public virtual ICollection<ApprovalMashCareService> ApprovalMashCareServices { get; set; } = new List<ApprovalMashCareService>();

    public virtual ApprovalRating? ApprovalRating { get; set; }

    public virtual ICollection<ApprovalService> ApprovalServices { get; set; } = new List<ApprovalService>();

    public virtual ICollection<ApprovalsArchive> ApprovalsArchives { get; set; } = new List<ApprovalsArchive>();

    public virtual ICollection<ApprovalsLog> ApprovalsLogs { get; set; } = new List<ApprovalsLog>();

    public virtual ICollection<ApprovalsPrivateNote> ApprovalsPrivateNotes { get; set; } = new List<ApprovalsPrivateNote>();

    public virtual ICollection<ApprovalsTagsMap> ApprovalsTagsMaps { get; set; } = new List<ApprovalsTagsMap>();

    public virtual ICollection<Approval> InverseParentApprovalNavigation { get; set; } = new List<Approval>();

    public virtual ICollection<MashPayment> MashPaymentApprovalNavigations { get; set; } = new List<MashPayment>();

    public virtual ICollection<MashPayment> MashPaymentApprovals { get; set; } = new List<MashPayment>();

    public virtual ICollection<McAuthenticateLog> McAuthenticateLogs { get; set; } = new List<McAuthenticateLog>();

    public virtual Member Member { get; set; } = null!;

    public virtual MemberPlan? MemberPlan { get; set; }

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual Approval? ParentApprovalNavigation { get; set; }

    public virtual ContractPlan? PlanCodeNavigation { get; set; }

    public virtual Inquery? Req { get; set; }

    public virtual VendorBranch? VBranch { get; set; }

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual ICollection<OnlineDiagnosis> Diagnoses { get; set; } = new List<OnlineDiagnosis>();
}
