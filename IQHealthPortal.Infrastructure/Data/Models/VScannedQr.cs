using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VScannedQr
{
    public decimal Rcode { get; set; }

    public decimal ActId { get; set; }

    public int? Serial { get; set; }

    public string? Member { get; set; }

    public string? MemberName { get; set; }

    public string? VendorName { get; set; }

    public string? CareItemName { get; set; }

    public string Note { get; set; } = null!;
}
