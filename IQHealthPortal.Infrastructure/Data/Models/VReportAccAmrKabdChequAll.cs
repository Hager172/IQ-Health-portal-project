using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReportAccAmrKabdChequAll
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

    public decimal? PaidValue { get; set; }

    public decimal? Credit { get; set; }

    public string? AccountCode { get; set; }

    public string? DocDestName { get; set; }

    public decimal? TahweelSandookRaese { get; set; }

    public decimal JeSerial { get; set; }

    public decimal? MostahDafa { get; set; }

    public decimal? MostahDafa1 { get; set; }

    public decimal? MostahDafa2 { get; set; }
}
