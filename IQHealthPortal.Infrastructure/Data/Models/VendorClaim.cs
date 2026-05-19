using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorClaim
{
    public int ClaimId { get; set; }

    public string VendorId { get; set; } = null!;

    public int? ClaimSerialStart { get; set; }

    public int? ClaimSerialEnd { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? DeleteStatus { get; set; }

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
