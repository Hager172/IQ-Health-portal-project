using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserVerification
{
    public string UserCode { get; set; } = null!;

    public string VerifyCode { get; set; } = null!;

    public DateTime ExpireDate { get; set; }

    public int Type { get; set; }

    public virtual AspNetUser UserCodeNavigation { get; set; } = null!;
}
