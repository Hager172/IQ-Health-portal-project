using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomersAllNoteState22
{
    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string? CustomerContractId { get; set; }

    public string? PaymentType { get; set; }

    public short? BillStatus { get; set; }

    public decimal? BillId { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BillValue { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public decimal? Collected { get; set; }

    public decimal? Balance { get; set; }

    public string? ContractType { get; set; }

    public int? InsurerId { get; set; }

    public string? InsurerName { get; set; }

    public int? GroupId { get; set; }

    public decimal? ExternalCode { get; set; }

    public string? CustomerTaxCard { get; set; }

    public double? Creditvalue { get; set; }

    public double? Debitvalue { get; set; }

    public string? String3 { get; set; }

    public string? CustomerAddress { get; set; }

    public string ActivityName { get; set; } = null!;

    public DateTime? BillPeriodFrom { get; set; }

    public DateTime? BillPeriodTo { get; set; }

    public decimal? BillSerial { get; set; }

    public string? CustomerContractCategory { get; set; }

    public int? AccPatientCategoryId { get; set; }
}
