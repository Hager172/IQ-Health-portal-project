using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class FollowUpResponse
{
    public int ResponseId { get; set; }

    public int FollowId { get; set; }

    public int StId { get; set; }

    public int? VRate { get; set; }

    public long? AppRate { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public int? UserRate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? Notes { get; set; }

    public virtual ApprovalRating? AppRateNavigation { get; set; }

    public virtual ApprovalFollowUp Follow { get; set; } = null!;

    public virtual FollowUpResponseStatus St { get; set; } = null!;

    public virtual VendorRating? VRateNavigation { get; set; }
}
