using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class LocalTicket
{
    public int LocalId { get; set; }

    public int LocalType { get; set; }

    public string? LocalStatus { get; set; }

    public string? LocalNote { get; set; }

    public string? StimatedValue { get; set; }

    public DateOnly? StimatedTime { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string LocalFromGroup { get; set; } = null!;

    public virtual ICollection<LocalTicketsReply> LocalTicketsReplies { get; set; } = new List<LocalTicketsReply>();

    public virtual ICollection<AspNetUser> LocalGroups { get; set; } = new List<AspNetUser>();
}
