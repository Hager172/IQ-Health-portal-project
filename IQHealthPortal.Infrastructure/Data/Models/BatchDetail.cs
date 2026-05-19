using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BatchDetail
{
    public decimal BatchId { get; set; }

    public int Serial { get; set; }

    public DateOnly ServiceDate { get; set; }

    public long ApprovalNumber { get; set; }

    public string MemberCode { get; set; } = null!;

    public int ServiceCode { get; set; }

    public int MedItem { get; set; }

    public int? InsuranceMedItem { get; set; }

    public double Value { get; set; }

    public double CoPayment { get; set; }

    public double RevDis { get; set; }

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

    public string? Status { get; set; }

    public bool? TpaRev { get; set; }

    public int? TpaNotify { get; set; }

    public string? FinancialRevNote { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual ICollection<BatchesPrivateNote> BatchesPrivateNotes { get; set; } = new List<BatchesPrivateNote>();

    public virtual VendorGeneral? CashVendorNavigation { get; set; }

    public virtual ContractActivity? ContractActivity1 { get; set; }

    public virtual ContractType1 ContractActivityNavigation { get; set; } = null!;

    public virtual ICollection<DisRefund> DisRefundBatchDetails { get; set; } = new List<DisRefund>();

    public virtual ICollection<DisRefund> DisRefundInvs { get; set; } = new List<DisRefund>();

    public virtual ICollection<InvDetail> InvDetails { get; set; } = new List<InvDetail>();

    public virtual CareItem MedItemNavigation { get; set; } = null!;

    public virtual Member MemberCodeNavigation { get; set; } = null!;

    public virtual MemberPlan? MemberPlan { get; set; }

    public virtual StandardService ServiceCodeNavigation { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual ICollection<OnlineDiagnosis> Dignoses { get; set; } = new List<OnlineDiagnosis>();
}
