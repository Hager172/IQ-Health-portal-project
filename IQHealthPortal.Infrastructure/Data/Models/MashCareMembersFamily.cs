using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MashCareMembersFamily
{
    public string ChildId { get; set; } = null!;

    public string? ParentId { get; set; }

    public virtual Member Child { get; set; } = null!;

    public virtual Member? Parent { get; set; }
}
