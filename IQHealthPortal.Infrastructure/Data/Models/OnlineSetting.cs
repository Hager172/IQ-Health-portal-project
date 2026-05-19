using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineSetting
{
    public string Item { get; set; } = null!;

    public int? Value { get; set; }

    public string? Text { get; set; }

    public string? Description { get; set; }
}
