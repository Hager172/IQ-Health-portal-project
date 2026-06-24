using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebMemberItem
{
    public long MemberItemId { get; set; }

    public long Item { get; set; }

    public long Member { get; set; }

    public string? Comment { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public double? CoverageLimit { get; set; }

    public string? ResposeBy { get; set; }

    public string? Currency { get; set; }

    public string? Customer { get; set; }

    public virtual WebCareItem ItemNavigation { get; set; } = null!;
}
