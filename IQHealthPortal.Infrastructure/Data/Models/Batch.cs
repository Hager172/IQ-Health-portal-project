using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Batch
{
    public decimal BatchId { get; set; }

    public string BatchVendorId { get; set; } = null!;

    public string? BatchNote { get; set; }

    public int BatchNumber { get; set; }

    public DateOnly? BatchDate { get; set; }

    public DateOnly BatchReceivedDate { get; set; }

    public int? BatchInvoiceNumber { get; set; }

    public double BatchCost { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? BatchStatus { get; set; }

    public bool BatchFinancialFlag { get; set; }

    public bool BatchMedicalFlag { get; set; }

    public bool? BatchLockFlag { get; set; }

    public DateOnly? BatchCreationDate { get; set; }

    public string? ReimbursementInfo { get; set; }

    public string? MedicallyRevisedBy { get; set; }

    public DateTime? MedicallyRevisedDate { get; set; }

    public DateTime? FinancialRevisedDate { get; set; }

    public string? FinancialRevisedBy { get; set; }

    public bool? FinancialLock { get; set; }

    public double? XtraValue { get; set; }

    public string? XtraNote { get; set; }

    public string? CurrentStep { get; set; }

    public string? MedicalrevNote { get; set; }

    public DateOnly? BatchSubmissionDate { get; set; }

    public int? CustomerId { get; set; }

    public decimal? PerentId { get; set; }

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual ICollection<BatchLog> BatchLogs { get; set; } = new List<BatchLog>();

    public virtual StateRef? BatchStatusNavigation { get; set; }

    public virtual VendorGeneral BatchVendor { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ICollection<DueAttachedFile> DueAttachedFiles { get; set; } = new List<DueAttachedFile>();

    public virtual ICollection<GroupBatch> GroupBatches { get; set; } = new List<GroupBatch>();

    public virtual ICollection<Batch> InversePerent { get; set; } = new List<Batch>();

    public virtual ICollection<MordeenSupplied> MordeenSupplieds { get; set; } = new List<MordeenSupplied>();

    public virtual Batch? Perent { get; set; }
}
