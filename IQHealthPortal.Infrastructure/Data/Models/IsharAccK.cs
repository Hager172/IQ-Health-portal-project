using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class IsharAccK
{
    public decimal AdjNo { get; set; }

    public decimal? AdjNo1 { get; set; }

    public string? SaBcode { get; set; }

    public DateTime AdjDate { get; set; }

    public string AdjStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Source1 { get; set; }

    public string? Omla { get; set; }

    public decimal? Tahweel { get; set; }

    public decimal Mony { get; set; }

    public string? AmeelNo { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? UserSerial { get; set; }

    public DateTime? BillPeriodFrom { get; set; }

    public DateTime? BillPeriodTo { get; set; }

    public decimal? AccServicesValue { get; set; }

    public decimal? DiscountRatio { get; set; }

    public decimal? KemaModafa { get; set; }

    public string? AccountCode { get; set; }

    public string? CostCenter { get; set; }

    public string? EdafaFaeda { get; set; }

    public string? CompanyCode { get; set; }

    public string? MontagatCode { get; set; }

    public string? RegonCode { get; set; }

    public string MohafzatCode { get; set; } = null!;

    public string WehdatCode { get; set; } = null!;

    public string MagmoatCode { get; set; } = null!;

    public decimal? Tax1 { get; set; }

    public decimal? Desc1 { get; set; }
}
