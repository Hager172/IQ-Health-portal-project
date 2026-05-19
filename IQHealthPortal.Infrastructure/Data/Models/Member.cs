using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Member
{
    public string MemberId { get; set; } = null!;

    public int MemberCustomerId { get; set; }

    public string MemberName { get; set; } = null!;

    public string MemberGender { get; set; } = null!;

    public DateOnly? MemberBirthday { get; set; }

    public string? MemberNationalId { get; set; }

    public string? MemberJob { get; set; }

    public bool MemberVip { get; set; }

    public string? MemberTele { get; set; }

    public string? MemberTele2 { get; set; }

    public string? MemberTele3 { get; set; }

    public string? MemberCompanyId { get; set; }

    public string? MemberExternalCode { get; set; }

    public string? MemberNotes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int? MemberCareCardId { get; set; }

    public DateOnly? MemberCareCardDate { get; set; }

    public int? MemberCareCardValue { get; set; }

    public string? MemberCareCardStatus { get; set; }

    public DateTime? MemberSubDate { get; set; }

    public DateTime MemberCreationDate { get; set; }

    public string MemberStatues { get; set; } = null!;

    public bool? MemberEip { get; set; }

    public bool? MemberFrequent { get; set; }

    public string? MemberParent { get; set; }

    public bool? MemberOnlineApprovals { get; set; }

    public string? MemberClass { get; set; }

    public string? MobPlatform { get; set; }

    public string? MobToken { get; set; }

    public int? MobPushFlag { get; set; }

    public string? Password { get; set; }

    public string? MailCode { get; set; }

    public string? PhoneCode { get; set; }

    public string? IsRegistered { get; set; }

    public string? FmcToken { get; set; }

    public string? AlarmMsg { get; set; }

    public string? Email { get; set; }

    public int? AreaId { get; set; }

    public string? MemberAddress { get; set; }

    public string? BankNumber { get; set; }

    public string? AccountNumber { get; set; }

    public bool? ShowMobProfile { get; set; }

    public bool? HasSanda { get; set; }

    public virtual ICollection<ApprovalRating> ApprovalRatings { get; set; } = new List<ApprovalRating>();

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual Area? Area { get; set; }

    public virtual ICollection<AspNetUser> AspNetUsers { get; set; } = new List<AspNetUser>();

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<CustomerComplaint> CustomerComplaints { get; set; } = new List<CustomerComplaint>();

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual ICollection<Inquery> InqueryReqMemberNavigations { get; set; } = new List<Inquery>();

    public virtual ICollection<Inquery> InqueryReqParentNavigations { get; set; } = new List<Inquery>();

    public virtual ICollection<InstallmentBilldetail> InstallmentBilldetails { get; set; } = new List<InstallmentBilldetail>();

    public virtual ICollection<Member> InverseMemberParentNavigation { get; set; } = new List<Member>();

    public virtual MashCareMembersFamily? MashCareMembersFamilyChild { get; set; }

    public virtual ICollection<MashCareMembersFamily> MashCareMembersFamilyParents { get; set; } = new List<MashCareMembersFamily>();

    public virtual ICollection<MemberArchiveDoc> MemberArchiveDocs { get; set; } = new List<MemberArchiveDoc>();

    public virtual ICollection<MemberContact> MemberContacts { get; set; } = new List<MemberContact>();

    public virtual Customer MemberCustomer { get; set; } = null!;

    public virtual ICollection<MemberFamily> MemberFamilies { get; set; } = new List<MemberFamily>();

    public virtual Member? MemberParentNavigation { get; set; }

    public virtual ICollection<MemberPlanAuthenticateLog> MemberPlanAuthenticateLogs { get; set; } = new List<MemberPlanAuthenticateLog>();

    public virtual ICollection<MemberPlan> MemberPlans { get; set; } = new List<MemberPlan>();

    public virtual StateRef MemberStatuesNavigation { get; set; } = null!;

    public virtual ICollection<MemberStatusMonitor> MemberStatusMonitors { get; set; } = new List<MemberStatusMonitor>();

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual ICollection<MembersLog> MembersLogs { get; set; } = new List<MembersLog>();

    public virtual ICollection<MembersPlanItem> MembersPlanItems { get; set; } = new List<MembersPlanItem>();

    public virtual ICollection<Sandum> Sanda { get; set; } = new List<Sandum>();

    public virtual ICollection<SchApproval> SchApprovals { get; set; } = new List<SchApproval>();

    public virtual ICollection<TempMember> TempMembers { get; set; } = new List<TempMember>();

    public virtual ICollection<VendorRating> VendorRatings { get; set; } = new List<VendorRating>();

    public virtual ICollection<VitalSignsMember> VitalSignsMembers { get; set; } = new List<VitalSignsMember>();

    public virtual ICollection<WafdeenMembersSchedule> WafdeenMembersSchedules { get; set; } = new List<WafdeenMembersSchedule>();

    public virtual ICollection<WafdeenVisit> WafdeenVisits { get; set; } = new List<WafdeenVisit>();

    public virtual ICollection<WithContractedPrice> WithContractedPrices { get; set; } = new List<WithContractedPrice>();

    public virtual ICollection<OnlineDiagnosis> Diagnoses { get; set; } = new List<OnlineDiagnosis>();
}
