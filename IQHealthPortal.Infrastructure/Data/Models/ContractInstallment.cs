using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractInstallment
{
    public string InstallmentId { get; set; } = null!;

    public string? PaymentType { get; set; }

    public DateOnly InstallmentDate { get; set; }

    public bool? IsValue { get; set; }

    public double? InstallmentValue { get; set; }

    public string? LastUpdatedFrom { get; set; }

    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Notes { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public bool? IsContractMembers { get; set; }

    public virtual CustomerContract CustomerContract { get; set; } = null!;

    public virtual ICollection<InstallmentBilldetail> InstallmentBilldetails { get; set; } = new List<InstallmentBilldetail>();

    public virtual PaymentType? PaymentTypeNavigation { get; set; }
}
