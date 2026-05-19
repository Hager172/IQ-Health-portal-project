using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineMessage
{
    public long MessageId { get; set; }

    public string MessageTitle { get; set; } = null!;

    public string MessageContentText { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public long FromUserId { get; set; }

    public long ToUserId { get; set; }

    public short MessageStatus { get; set; }

    public virtual OnlineUser FromUser { get; set; } = null!;

    public virtual OnlineUser ToUser { get; set; } = null!;
}
