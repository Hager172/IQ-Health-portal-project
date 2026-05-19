using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class StatusProcedure
{
    public int Id { get; set; }

    public string? ProcStatus { get; set; }

    public virtual ICollection<ApprovalFollowUp> ApprovalFollowUps { get; set; } = new List<ApprovalFollowUp>();

    public virtual ICollection<BatchLog> BatchLogs { get; set; } = new List<BatchLog>();

    public virtual ICollection<CrmContractExcutor> CrmContractExcutors { get; set; } = new List<CrmContractExcutor>();

    public virtual ICollection<CrmCustomerContract> CrmCustomerContracts { get; set; } = new List<CrmCustomerContract>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual ICollection<PrivilegeRequest> PrivilegeRequests { get; set; } = new List<PrivilegeRequest>();

    public virtual ICollection<SandaScheduleLog> SandaScheduleLogs { get; set; } = new List<SandaScheduleLog>();

    public virtual ICollection<SandaSchedule> SandaSchedules { get; set; } = new List<SandaSchedule>();

    public virtual ICollection<Ticket> TicketNeedApprovalNavigations { get; set; } = new List<Ticket>();

    public virtual ICollection<Ticket> TicketRequestStatusNavigations { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketsReply> TicketsReplyNeedApprovalNavigations { get; set; } = new List<TicketsReply>();

    public virtual ICollection<TicketsReply> TicketsReplyRequestStatusNavigations { get; set; } = new List<TicketsReply>();

    public virtual ICollection<VisitProcedure> VisitProcedures { get; set; } = new List<VisitProcedure>();
}
