using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int RequestType { get; set; }

    public int? RequestStatus { get; set; }

    public string? RequestNote { get; set; }

    public int? MenuId { get; set; }

    public string? StimatedValue { get; set; }

    public DateOnly? StimatedTime { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public int? ClientId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? NeedApproval { get; set; }

    public string? Priority { get; set; }

    public string? AssignedTo { get; set; }

    public int? Department { get; set; }

    public DateTime? DueTime { get; set; }

    public int? ProjectId { get; set; }

    public bool? HaveFiles { get; set; }

    public int? ParentTicket { get; set; }

    public virtual Client? Client { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual Department? DepartmentNavigation { get; set; }

    public virtual ICollection<Ticket> InverseParentTicketNavigation { get; set; } = new List<Ticket>();

    public virtual StatusProcedure? NeedApprovalNavigation { get; set; }

    public virtual Ticket? ParentTicketNavigation { get; set; }

    public virtual Project? Project { get; set; }

    public virtual StatusProcedure? RequestStatusNavigation { get; set; }

    public virtual ICollection<TicketsReply> TicketsReplies { get; set; } = new List<TicketsReply>();
}
