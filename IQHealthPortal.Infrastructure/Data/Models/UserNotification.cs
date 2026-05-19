using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserNotification
{
    public long NoteId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime? SeenAt { get; set; }

    public virtual AcmsNotification Note { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
