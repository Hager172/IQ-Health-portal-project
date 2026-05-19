using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalsArchiveOnline
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public long ApprovalId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime? LastUpdateDate { get; set; }
}
