using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OutlookEmail
{
    public int Id { get; set; }

    public string? EmailName { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime? DateEmail { get; set; }

    public string? EmailCc { get; set; }

    public string? EntryId { get; set; }

    public long? ApprovalId { get; set; }

    public virtual ICollection<OutlookAttachment> OutlookAttachments { get; set; } = new List<OutlookAttachment>();
}
