using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PrivilegeLog
{
    public int LogId { get; set; }

    public string LoggedUser { get; set; } = null!;

    public string UpdatedUser { get; set; } = null!;

    public int ActionId { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? PrivilegeName { get; set; }

    public string? Note { get; set; }
}
