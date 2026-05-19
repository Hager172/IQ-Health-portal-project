using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SchApprovalsArchive
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Path { get; set; } = null!;

    public long TempId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual SchApproval Temp { get; set; } = null!;
}
