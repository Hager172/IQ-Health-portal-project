using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerBillTpa
{
    public long Id { get; set; }

    public long BillId { get; set; }

    public int CustomerId { get; set; }

    public decimal Value { get; set; }

    public string ContractId { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
