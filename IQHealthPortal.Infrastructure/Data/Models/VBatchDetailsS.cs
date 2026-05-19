using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VBatchDetailsS
{
    public decimal BatchId { get; set; }

    public int Serial { get; set; }

    public DateOnly ServiceDate { get; set; }

    public long ApprovalNumber { get; set; }

    public string MemberCode { get; set; } = null!;

    public int ServiceCode { get; set; }

    public int? MedItem { get; set; }

    public int? InsuranceMedItem { get; set; }

    public double? Value { get; set; }

    public double CoPayment { get; set; }

    public double? RevDis { get; set; }

    public double? Num { get; set; }

    public double? Tax { get; set; }

    public string? Note { get; set; }

    public double LocalDis { get; set; }

    public double ImportDis { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int? InvNum { get; set; }

    public long InvId { get; set; }

    public bool? Notified { get; set; }

    public bool MedRevised { get; set; }

    public bool FinRevised { get; set; }

    public string? DisNote { get; set; }

    public bool? HasDoc { get; set; }

    public string? ContractCode { get; set; }

    public string? OldServid { get; set; }

    public string VendorId { get; set; } = null!;

    public int CustomerId { get; set; }

    public int? Insurer { get; set; }

    public string ContractActivity { get; set; } = null!;

    public int ActivitySerial { get; set; }

    public string IsActualCost { get; set; } = null!;

    public string? MedRevNote { get; set; }

    public string? CashVendor { get; set; }

    public int? TpaNotify { get; set; }
}
