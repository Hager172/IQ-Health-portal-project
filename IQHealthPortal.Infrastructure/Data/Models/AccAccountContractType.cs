using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccAccountContractType
{
    public decimal AccAccountNumber { get; set; }

    public string ContractType { get; set; } = null!;
}
