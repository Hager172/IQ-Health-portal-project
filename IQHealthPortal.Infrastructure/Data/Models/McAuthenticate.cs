using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class McAuthenticate
{
    public int Id { get; set; }

    public string? Password { get; set; }

    public bool? Enabled { get; set; }

    public int? Type { get; set; }

    public virtual ICollection<McAuthenticateLog> McAuthenticateLogs { get; set; } = new List<McAuthenticateLog>();

    public virtual ICollection<MemberPlanAuthenticateLog> MemberPlanAuthenticateLogs { get; set; } = new List<MemberPlanAuthenticateLog>();
}
