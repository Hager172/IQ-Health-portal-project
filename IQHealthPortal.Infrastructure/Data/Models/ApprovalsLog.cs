using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalsLog
{
    public int Id { get; set; }

    public long ApprovalId { get; set; }

    public int NumServices { get; set; }

    public DateTime ApprovalDate { get; set; }

    public string MemberId { get; set; } = null!;

    public string? Notes { get; set; }

    public string? PrivateNotes { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public double Price { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public int Action { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;

    public virtual Approval Approval { get; set; } = null!;
}
