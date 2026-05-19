using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TaxPayment
{
    public int Id { get; set; }

    public DateTime PaymentDate { get; set; }

    public string PaymentNumber { get; set; } = null!;

    public int YearDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public int Quarter { get; set; }
}
