using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebVIcustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int? CustomerContractInsurer { get; set; }

    public string CustomerContractId { get; set; } = null!;
}
