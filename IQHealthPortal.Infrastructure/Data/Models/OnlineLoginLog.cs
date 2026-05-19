using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineLoginLog
{
    public long? UserId { get; set; }

    public DateTime? StartTime { get; set; }

    public string? Ip { get; set; }

    public string? BrowserInf { get; set; }

    public DateTime? EndTime { get; set; }

    public string SessionId { get; set; } = null!;

    public string? UserName { get; set; }
}
