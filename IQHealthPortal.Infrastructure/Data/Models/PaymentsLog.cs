using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PaymentsLog
{
    public int Id { get; set; }

    public string PaymentsId { get; set; } = null!;

    public int NumBatches { get; set; }

    public DateTime PaymentDate { get; set; }

    public string VendorId { get; set; } = null!;

    public string? Notes { get; set; }

    public double NetFees { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public int Action { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;
}
