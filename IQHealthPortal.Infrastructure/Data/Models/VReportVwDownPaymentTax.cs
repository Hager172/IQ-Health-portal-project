using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReportVwDownPaymentTax
{
    public decimal AdjNo { get; set; }

    public decimal AdjNo1 { get; set; }

    public string? SaBcode { get; set; }

    public string? ClaimType { get; set; }

    public string? DocNo1 { get; set; }

    public decimal? DedTaxes { get; set; }

    public string? StVcode { get; set; }
}
