using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MembersPlanItem
{
    public string MemberId { get; set; } = null!;

    public string PlanId { get; set; } = null!;

    public int ItemId { get; set; }

    public string AddedBy { get; set; } = null!;

    public DateTime AddedAt { get; set; }

    public string AddedFrom { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
