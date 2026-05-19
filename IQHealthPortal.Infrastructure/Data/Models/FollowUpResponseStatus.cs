using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class FollowUpResponseStatus
{
    public int StatusResId { get; set; }

    public string StatusColor { get; set; } = null!;

    public string? StatusNameEn { get; set; }

    public virtual ICollection<FollowUpResponse> FollowUpResponses { get; set; } = new List<FollowUpResponse>();
}
