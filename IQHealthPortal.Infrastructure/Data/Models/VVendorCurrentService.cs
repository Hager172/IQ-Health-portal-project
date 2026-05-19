using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorCurrentService
{
    public int ContractServiceId { get; set; }

    public double? ContractServicePrices { get; set; }

    public int? ContractServiceSerRef { get; set; }

    public string? ContractServiceName { get; set; }

    public string? StandServiceName { get; set; }

    public string? StandServiceAvailability { get; set; }

    public int? StandServiceParent { get; set; }

    public string Vid { get; set; } = null!;
}
