using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WhatIsNew
{
    public int Id { get; set; }

    public string ActionName { get; set; } = null!;

    public string ActionDescription { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public int? PageId { get; set; }

    public string? Note { get; set; }

    public bool? IsDevelopment { get; set; }

    public int? PrivilegeId { get; set; }

    public string? RoleId { get; set; }

    public virtual AspNetRole? Role { get; set; }

    public virtual ICollection<WhatIsNewNotification> WhatIsNewNotifications { get; set; } = new List<WhatIsNewNotification>();
}
