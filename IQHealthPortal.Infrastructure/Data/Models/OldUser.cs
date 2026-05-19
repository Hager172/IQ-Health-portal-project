using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OldUser
{
    public string UserLogon { get; set; } = null!;

    public string? UserPwd { get; set; }
}
