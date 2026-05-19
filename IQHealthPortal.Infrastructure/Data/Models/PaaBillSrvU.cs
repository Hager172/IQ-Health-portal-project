using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PaaBillSrvU
{
    public decimal AdjNo { get; set; }

    public decimal? AdjNo1 { get; set; }

    public string SaBcode { get; set; } = null!;

    public short BillType { get; set; }

    public string BillCat { get; set; } = null!;

    public decimal BillId { get; set; }

    public int? ItemId { get; set; }

    public string? SaEmpid { get; set; }

    public int? SaSerial { get; set; }

    public string? StIcode { get; set; }

    public decimal? SaQty { get; set; }

    public double? SaUintprice { get; set; }

    public double? SaUnittax { get; set; }

    public double? SaAddtax { get; set; }

    public string? SaItemDesc { get; set; }

    public DateTime? ServiceActionDate { get; set; }

    public double? Discount { get; set; }

    public int? MedItem { get; set; }

    public double? RevisionDiscount { get; set; }

    public double? MedicalDiscount { get; set; }

    public string? StVcode { get; set; }

    public decimal? SaRcode { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? StVnamea { get; set; }

    public double? ClaimValue { get; set; }

    public double? Net { get; set; }
}
