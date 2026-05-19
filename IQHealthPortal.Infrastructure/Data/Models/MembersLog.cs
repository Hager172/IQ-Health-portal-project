using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MembersLog
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int Action { get; set; }

    public string? Note { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
