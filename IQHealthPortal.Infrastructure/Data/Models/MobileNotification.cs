using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MobileNotification
{
    public int NotificationId { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool? Delivered { get; set; }

    public int TypeId { get; set; }

    public string? ToId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public DateTime SendDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public int? NotificationType { get; set; }

    public string? ImagePath { get; set; }

    public virtual AcmsOption? NotificationTypeNavigation { get; set; }

    public virtual AcmsOption Type { get; set; } = null!;
}
