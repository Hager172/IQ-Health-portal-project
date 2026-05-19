using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WithContractedPrice
{
    public int Id { get; set; }

    public string? VendorId { get; set; }

    public string? MemberId { get; set; }

    public string? PatientName { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? PStatus { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual Member? Member { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }
}
