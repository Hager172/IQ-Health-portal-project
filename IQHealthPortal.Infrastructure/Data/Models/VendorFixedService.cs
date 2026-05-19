using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorFixedService
{
    public int FixedServiceId { get; set; }

    public string FixedServiceName { get; set; } = null!;

    public double? FixedServicePrice { get; set; }

    public int? StandServiceRef { get; set; }

    public int NeqabaId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? Notes { get; set; }

    public virtual Neqabat Neqaba { get; set; } = null!;

    public virtual StandardService? StandServiceRefNavigation { get; set; }
}
