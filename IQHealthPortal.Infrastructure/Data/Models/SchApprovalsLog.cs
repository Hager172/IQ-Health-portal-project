using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SchApprovalsLog
{
    public int Id { get; set; }

    public long TempId { get; set; }

    public int NumServices { get; set; }

    public string? Notes { get; set; }

    public string? PrivateNotes { get; set; }

    public double Price { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int Action { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;

    public virtual SchApproval Temp { get; set; } = null!;
}
