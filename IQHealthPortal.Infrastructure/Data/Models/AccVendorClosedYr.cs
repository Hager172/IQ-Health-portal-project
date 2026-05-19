using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccVendorClosedYr
{
    public short ClosedYear { get; set; }

    public string VendorId { get; set; } = null!;

    public double? Balance { get; set; }

    public int? RefId { get; set; }

    public DateTime? ClosedDate { get; set; }

    public DateTime? ActionDate { get; set; }

    public virtual AccFinancialYr? AccFinancialYr { get; set; }

    public virtual AccFinancialYr? Ref { get; set; }

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
