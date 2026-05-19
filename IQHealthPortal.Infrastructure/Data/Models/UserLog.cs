using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserLog
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int Action { get; set; }

    public DateTime EnteredDate { get; set; }

    public string? EnteredFrom { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public string? UserGroup { get; set; }

    public string? Note { get; set; }
}
