using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetAcmsNotificationsDatum
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Body { get; set; }

    public string? Link { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ActionId { get; set; }

    public string Type { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public long ApprovalId { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int IsConditionTrue { get; set; }
}
