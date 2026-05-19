using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Claim
{
    public int CalimId { get; set; }

    public string ClaimVendorId { get; set; } = null!;

    public int? ClaimStartSerial { get; set; }

    public int? ClaimEndSerial { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual VendorGeneral ClaimVendor { get; set; } = null!;
}
