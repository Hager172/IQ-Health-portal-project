using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerComplaint
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Complaint { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? VendorId { get; set; }

    public int? Type { get; set; }

    public bool? Closed { get; set; }

    public string? Respond { get; set; }

    public string? MemberId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Member? Member { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }
}
