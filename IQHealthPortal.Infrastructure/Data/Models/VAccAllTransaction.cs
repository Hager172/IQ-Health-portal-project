using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAccAllTransaction
{
    public string? AdjNo { get; set; }

    public int? Serial { get; set; }

    public int? DocType { get; set; }

    public int? BillType { get; set; }

    public int? BillId { get; set; }

    public string? AccountCode { get; set; }

    public int? ItemId { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

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

    public decimal? Mony1 { get; set; }

    public int? MontagatCode { get; set; }

    public string? AdjNo1 { get; set; }

    public DateOnly? AdjDate { get; set; }

    public decimal? Mony1R { get; set; }

    public string? BankKhaznaNo { get; set; }

    public string? HesapNo { get; set; }

    public string? AmeelNo { get; set; }

    public int? RegonCode { get; set; }

    public string? Expr1 { get; set; }

    public int? MohafzatCode { get; set; }

    public int? WehdatCode { get; set; }

    public int? MagmoatCode { get; set; }

    public string? Source1 { get; set; }

    public decimal? Mony { get; set; }

    public string? ContractId { get; set; }

    public string? Account1 { get; set; }
}
