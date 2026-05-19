using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetallcontractserv
{
    public string? VendorName { get; set; }

    public string? VendorId { get; set; }

    public int ContractServiceId { get; set; }

    public string ContractServiceName { get; set; } = null!;
}
