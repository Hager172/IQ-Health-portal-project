using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OutlookAttachment
{
    public int Id { get; set; }

    public int? OutlookEmailId { get; set; }

    public string? FileName { get; set; }

    public virtual OutlookEmail? OutlookEmail { get; set; }
}
