using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomersContractMaster
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string ContractId { get; set; } = null!;

    public bool? IsMaster { get; set; }

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
