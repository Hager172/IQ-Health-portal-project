using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalsPrivateNote
{
    public int Id { get; set; }

    public long ApprovalId { get; set; }

    public string PrivateNote { get; set; } = null!;

    public string WrittenBy { get; set; } = null!;

    public DateTime Date { get; set; }

    public int Type { get; set; }

    public virtual Approval Approval { get; set; } = null!;
}
