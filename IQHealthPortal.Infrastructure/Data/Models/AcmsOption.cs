using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsOption
{
    public int OptId { get; set; }

    public int? OptGroup { get; set; }

    public string OptName { get; set; } = null!;

    public string? OptNameAr { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AcmsOption> InverseOptGroupNavigation { get; set; } = new List<AcmsOption>();

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual ICollection<MobileNotification> MobileNotificationNotificationTypeNavigations { get; set; } = new List<MobileNotification>();

    public virtual ICollection<MobileNotification> MobileNotificationTypes { get; set; } = new List<MobileNotification>();

    public virtual AcmsOption? OptGroupNavigation { get; set; }

    public virtual ICollection<EntityReviewResponse> Responses { get; set; } = new List<EntityReviewResponse>();

    public virtual ICollection<ServiceReviewResponse> ResponsesNavigation { get; set; } = new List<ServiceReviewResponse>();
}
