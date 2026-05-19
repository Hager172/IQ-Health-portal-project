using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAllContracttypeCustomersNote
{
    public string CustomerName { get; set; } = null!;

    public string? ContractType { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public DateTime CustomerContractStartDate { get; set; }

    public DateTime CustomerContractEndDate { get; set; }

    public int? Members { get; set; }

    public double? Value { get; set; }
}
