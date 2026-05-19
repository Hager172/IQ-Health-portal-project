using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomerContractsQuarterYear
{
    public string CustomerName { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;

    public DateTime CustomerContractStartDate { get; set; }

    public DateTime CustomerContractEndDate { get; set; }

    public int CustomerId { get; set; }
}
