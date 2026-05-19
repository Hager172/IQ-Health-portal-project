using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserCustomer
{
    public string UserId { get; set; } = null!;

    public int CustomerId { get; set; }

    public string RoleId { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual AspNetRole Role { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
