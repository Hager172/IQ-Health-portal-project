using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class LocalTicketsReply
{
    public int ReplyLoaclId { get; set; }

    public int ReplyTicketId { get; set; }

    public string ReplyFromGroup { get; set; } = null!;

    public string? ReplyLoaclNote { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual LocalTicket ReplyTicket { get; set; } = null!;
}
