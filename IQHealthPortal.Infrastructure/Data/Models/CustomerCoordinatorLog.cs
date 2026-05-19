using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerCoordinatorLog
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public int ActionId { get; set; }

    public string RoleId { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual AspNetRole Role { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
