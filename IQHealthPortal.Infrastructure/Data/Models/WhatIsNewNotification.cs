using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WhatIsNewNotification
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int WhatIsNewId { get; set; }

    public DateTime? SeenAt { get; set; }

    public virtual AspNetUser User { get; set; } = null!;

    public virtual WhatIsNew WhatIsNew { get; set; } = null!;
}
