using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class McAuthenticateLog
{
    public int Id { get; set; }

    public int AuthenticationId { get; set; }

    public long ActCode { get; set; }

    public DateTime Time { get; set; }

    public string Machine { get; set; } = null!;

    public string? AdditionalInfo { get; set; }

    public virtual Approval ActCodeNavigation { get; set; } = null!;

    public virtual McAuthenticate Authentication { get; set; } = null!;
}
