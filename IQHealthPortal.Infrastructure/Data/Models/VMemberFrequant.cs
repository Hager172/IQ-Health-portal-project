using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMemberFrequant
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? MemberTele { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string Photo { get; set; } = null!;
}
