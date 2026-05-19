using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmcPage
{
    public int MenueId { get; set; }

    public string? MenueName { get; set; }

    public int? MenueParent { get; set; }

    public string? MenueType { get; set; }

    public string? MenueLink { get; set; }

    public string? MenueIcon { get; set; }

    public bool? MenueControl { get; set; }
}
