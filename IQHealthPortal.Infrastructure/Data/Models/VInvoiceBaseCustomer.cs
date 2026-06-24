using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VInvoiceBaseCustomer
{
    public decimal? DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal AdjNo { get; set; }

    public long? Serial { get; set; }

    public string? AccountCode { get; set; }

    public string? CustomerName { get; set; }

    public string? PaymentType { get; set; }

    public string? ContractId { get; set; }

    public string? AmeelNo { get; set; }

    public string? AmeelNo1 { get; set; }

    public string? Notes { get; set; }

    public float? Debit { get; set; }

    public double? Credit { get; set; }

    public short? BillStatus { get; set; }

    public string Source1 { get; set; } = null!;

    public int AdjNo1 { get; set; }

    public string? BankKhaznaNo { get; set; }

    public string? HesapNo { get; set; }

    public int Mony1R { get; set; }

    public int Mony { get; set; }

    public int ItemId { get; set; }

    public int? CostCenter { get; set; }

    public int? DocDestCode { get; set; }

    public int? OperatingUnit { get; set; }

    public int? GroupNo { get; set; }

    public int? CompanyCode { get; set; }

    public int? CompanyCode1 { get; set; }

    public string Omla { get; set; } = null!;

    public int? Tahweel { get; set; }

    public int? Mony1 { get; set; }

    public int? MontagatCode { get; set; }

    public int? RegonCode { get; set; }

    public int? MohafzatCode { get; set; }

    public int? WehdatCode { get; set; }

    public int? MagmoatCode { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }
}
