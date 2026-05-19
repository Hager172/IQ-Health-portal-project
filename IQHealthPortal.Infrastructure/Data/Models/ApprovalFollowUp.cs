using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalFollowUp
{
    public int Id { get; set; }

    public long ApprovalId { get; set; }

    public int FollowUpType { get; set; }

    public string? FollowUpDescription { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime FollowUpDate { get; set; }

    public string? FollowUpNotes { get; set; }

    public int Stauts { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public DateTime? PredictionOutDate { get; set; }

    public string? EntryCase { get; set; }

    public string? MemberStatus { get; set; }

    public int? FollowUpParent { get; set; }

    public int? DoctorId { get; set; }

    public bool? IsLast { get; set; }

    public virtual Approval Approval { get; set; } = null!;

    public virtual FollowupDoctor? Doctor { get; set; }

    public virtual ApprovalFollowUp? FollowUpParentNavigation { get; set; }

    public virtual ICollection<FollowUpResponse> FollowUpResponses { get; set; } = new List<FollowUpResponse>();

    public virtual FollowUpType FollowUpTypeNavigation { get; set; } = null!;

    public virtual ICollection<ApprovalFollowUp> InverseFollowUpParentNavigation { get; set; } = new List<ApprovalFollowUp>();

    public virtual StatusProcedure StautsNavigation { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
