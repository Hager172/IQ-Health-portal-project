using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAccCoreTransaction
{
    public decimal AdjNo { get; set; }

    public DateTime? AdjDate { get; set; }

    public int Serial { get; set; }

    public int? DocType { get; set; }

    public int? BillType { get; set; }

    public decimal? BillId { get; set; }

    public string? AccountCode { get; set; }

    public int? ItemId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? Comments { get; set; }

    public int? CostCenter { get; set; }

    public string? DocDestName { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? DocDestCode { get; set; }

    public int? OperatingUnit { get; set; }

    public int? GroupNo { get; set; }

    public int? CompanyCode { get; set; }

    public int? CompanyCode1 { get; set; }

    public string? Omla { get; set; }

    public decimal? Tahweel { get; set; }

    public double? Mony1 { get; set; }

    public int? MontagatCode { get; set; }

    public string? BankKhaznaNo { get; set; }

    public string? HesapNo { get; set; }

    public double? Mony1R { get; set; }

    public string? Notes { get; set; }

    public int? RegonCode { get; set; }

    public int? MohafzatCode { get; set; }

    public int? WehdatCode { get; set; }

    public int? MagmoatCode { get; set; }

    public decimal? AdjNo1 { get; set; }

    public string? AmeelNo { get; set; }

    public string? AdjStatus { get; set; }

    public string? GroupKind { get; set; }

    public DateTime? AdjDate2 { get; set; }
}
