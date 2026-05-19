using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAccInvoiceCollection
{
    public string Source { get; set; } = null!;

    public decimal AdjNo { get; set; }

    public DateTime AdjDate { get; set; }

    public string? DocDestName { get; set; }

    public string? Notes { get; set; }

    public string? AmeelNo { get; set; }

    public decimal? InvoiceNumber { get; set; }

    public string? DocNo1 { get; set; }

    public decimal? PaidValue { get; set; }

    public decimal? CashDiscount { get; set; }

    public decimal? DedTaxes { get; set; }
}
