using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReportAccAmrSarfKhazna
{
    public decimal AdjNo { get; set; }

    public string AdjStatus { get; set; } = null!;

    public DateTime AdjDate { get; set; }

    public string? BankKhaznaNo { get; set; }

    public string? AccountName { get; set; }

    public int? AmeelNo { get; set; }

    public string? AmeelName { get; set; }

    public string? MoredNo { get; set; }

    public string? MoredName { get; set; }

    public decimal? ValueI { get; set; }

    public decimal PaidValue { get; set; }

    public decimal? Debit { get; set; }

    public int ValueA { get; set; }

    public string? AccountCode { get; set; }

    public string? DocDestName { get; set; }

    public DateTime? DateTimePicker1 { get; set; }

    public string? CboCurrency { get; set; }

    public string? Notes { get; set; }

    public decimal? CashDiscount { get; set; }

    public decimal? DedTaxes { get; set; }

    public decimal? Stamps { get; set; }

    public decimal AdjNo1 { get; set; }

    public string? SourceName { get; set; }

    public string? SandookK { get; set; }

    public decimal? JeSerial { get; set; }

    public string? Note1 { get; set; }
}
