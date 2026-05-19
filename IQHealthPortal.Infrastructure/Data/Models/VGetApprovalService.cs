using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetApprovalService
{
    public int ServiceId { get; set; }

    public string? Name { get; set; }

    public int? Count { get; set; }
}
