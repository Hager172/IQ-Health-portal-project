using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PaymentType
{
    public string PaymentTypeId { get; set; } = null!;

    public string? PaymentType1 { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<ContractInstallment> ContractInstallments { get; set; } = new List<ContractInstallment>();
}
