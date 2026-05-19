using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SaReclaimdetB
{
    public decimal AdjNo { get; set; }

    public decimal? AdjNo1 { get; set; }

    public decimal SaRcode { get; set; }

    public string SaEmpid { get; set; } = null!;

    public decimal SaSerial { get; set; }

    public string StIcode { get; set; } = null!;

    public decimal? SaQty { get; set; }

    public double? SaUintprice { get; set; }

    public double? SaUnittax { get; set; }

    public double? SaAddtax { get; set; }

    public string? SaItemDesc { get; set; }

    public DateTime? ServiceActionDate { get; set; }

    public double? Discount { get; set; }

    public decimal? MedItem { get; set; }

    public double? RevisionDiscount { get; set; }

    public string? Notes { get; set; }

    public double? MedicalDiscount { get; set; }

    public double? ApprovalCode { get; set; }

    public string? Issent { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? PostFlag { get; set; }

    public decimal? BillId { get; set; }

    public string? StVcode { get; set; }

    public double? LocalDiscount { get; set; }

    public double? ImportedDiscount { get; set; }

    public double? Coinsurance { get; set; }

    public int? InsurerMeditem { get; set; }

    public string? ContractId { get; set; }

    public string? SrvName { get; set; }

    public string? Icd { get; set; }

    public string? CalcFlag { get; set; }
}
