using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReportTreasuryPaymentChecksAnalysis
{
    public decimal AdjNo { get; set; }

    public DateTime AdjDate { get; set; }

    public string AdjStatus { get; set; } = null!;

    public string? BankKhaznaNo { get; set; }

    public string AccountName { get; set; } = null!;

    public decimal? Mony1 { get; set; }

    public decimal? AdjNo1 { get; set; }

    public string? BankKhaznaNo1 { get; set; }

    public decimal? Mony2 { get; set; }

    public string? DocDestName { get; set; }

    public string? AccountName1 { get; set; }

    public decimal? JeSerial { get; set; }

    public string Kabd { get; set; } = null!;

    public DateTime? DateTimePicker1 { get; set; }

    public string? CboCurrency { get; set; }
}
