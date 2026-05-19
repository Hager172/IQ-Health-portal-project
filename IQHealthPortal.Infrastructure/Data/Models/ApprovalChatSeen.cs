using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalChatSeen
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public long ApprovalId { get; set; }

    public int? LastSeen { get; set; }

    public DateTime? LastSeenDate { get; set; }

    public virtual Approval Approval { get; set; } = null!;
}
