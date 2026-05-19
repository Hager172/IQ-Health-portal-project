using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetMember
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public int MemberCustomerId { get; set; }

    public string Contract { get; set; } = null!;
}
