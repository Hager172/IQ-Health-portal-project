using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VPriceIndex
{
    public string? ContractServiceName { get; set; }

    public int? ContractServiceSerRef { get; set; }

    public int? Cat { get; set; }

    public int? Gov { get; set; }

    public double? Price { get; set; }

    public int? Mapped { get; set; }
}
