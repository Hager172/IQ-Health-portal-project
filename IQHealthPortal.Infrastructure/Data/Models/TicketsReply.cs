using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TicketsReply
{
    public int ReplyId { get; set; }

    public int TicketId { get; set; }

    public int ReplyClientId { get; set; }

    public string? ReplyNote { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Priority { get; set; }

    public int? NeedApproval { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? RequestStatus { get; set; }

    public DateTime? DueTime { get; set; }

    public string? UserId { get; set; }

    public virtual StatusProcedure? NeedApprovalNavigation { get; set; }

    public virtual Client ReplyClient { get; set; } = null!;

    public virtual StatusProcedure? RequestStatusNavigation { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;
}
