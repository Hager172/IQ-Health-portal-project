using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorsAdsLink
{
    public string Link { get; set; } = null!;

    public int Cat { get; set; }

    public string Code { get; set; } = null!;
}
