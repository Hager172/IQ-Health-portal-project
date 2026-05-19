using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMemberComplaintsDetail
{
    public int Id { get; set; }

    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Complaint { get; set; } = null!;

    public string? Respond { get; set; }

    public bool Closed { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? VendorId { get; set; }

    public int? Type { get; set; }

    public long? ApprovalId { get; set; }

    public string? PhoneNumber { get; set; }

    public string CustomerName { get; set; } = null!;
}
