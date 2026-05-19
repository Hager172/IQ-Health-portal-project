using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CurrencyExchangable
{
    public int ExId { get; set; }

    public int CurrencyId { get; set; }

    public double Factor { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int? CustomerId { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual Customer? Customer { get; set; }
}
