using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalMashCareService
{
    public long ApprovalId { get; set; }

    public int ItemSerial { get; set; }

    public double? MashPrice { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual Approval Approval { get; set; } = null!;

    public virtual ApprovalService ApprovalService { get; set; } = null!;
}
