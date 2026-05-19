using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PaymentChannel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MashPayment> MashPayments { get; set; } = new List<MashPayment>();
}
