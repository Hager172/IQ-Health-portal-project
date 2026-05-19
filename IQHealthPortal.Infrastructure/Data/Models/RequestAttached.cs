using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class RequestAttached
{
    public int AttachId { get; set; }

    public long? AttachApprovalId { get; set; }

    public string? AttachName { get; set; }

    public string? AttachPath { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
