using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorExceptionContract
{
    public int Id { get; set; }

    public string VendorContractId { get; set; } = null!;

    public string VendorId { get; set; } = null!;

    public DateTime Start { get; set; }

    public DateTime? End { get; set; }

    public bool Status { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual VendorContract VendorContract { get; set; } = null!;
}
