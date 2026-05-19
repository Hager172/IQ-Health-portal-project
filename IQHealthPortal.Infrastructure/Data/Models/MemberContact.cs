using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberContact
{
    public int AddressId { get; set; }

    public string MemberId { get; set; } = null!;

    public string MemberAddress { get; set; } = null!;

    public string? MemberPhone { get; set; }

    public int MemberArea { get; set; }

    public virtual ICollection<Inquery> Inqueries { get; set; } = new List<Inquery>();

    public virtual Member Member { get; set; } = null!;

    public virtual Area MemberAreaNavigation { get; set; } = null!;
}
