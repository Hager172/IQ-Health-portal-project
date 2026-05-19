using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMashcareCon
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string ParentMemberName { get; set; } = null!;

    public string ParentMemberId { get; set; } = null!;

    public decimal Wallet { get; set; }

    public decimal Fawry { get; set; }
}
