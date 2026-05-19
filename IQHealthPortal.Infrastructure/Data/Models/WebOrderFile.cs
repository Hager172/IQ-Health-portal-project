using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebOrderFile
{
    public long FileId { get; set; }

    public string? FileName { get; set; }

    public string? Url { get; set; }

    public long? OrderId { get; set; }

    public virtual WebOrder? Order { get; set; }
}
