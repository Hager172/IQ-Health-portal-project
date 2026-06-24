using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class DefaultCustomer
{
    public string UserId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public int Project { get; set; }

    public virtual Project ProjectNavigation { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
