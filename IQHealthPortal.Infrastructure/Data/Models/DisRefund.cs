using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class DisRefund
{
    public int Id { get; set; }

    public long InvId { get; set; }

    public double Value { get; set; }

    public string Type { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string Notes { get; set; } = null!;

    public long? NotficatiohnId { get; set; }

    public int? Meditem { get; set; }

    public string Status { get; set; } = null!;

    public bool AsRev { get; set; }

    public string MemberId { get; set; } = null!;

    public int ActivitySerial { get; set; }

    public string ContractActivity { get; set; } = null!;

    public int CustomerId { get; set; }

    public string VendorId { get; set; } = null!;

    public int? Insurer { get; set; }

    public decimal BatchId { get; set; }

    public string ContractCode { get; set; } = null!;

    public int ValFactor { get; set; }

    public string? MedReview { get; set; }

    public string? FinReview { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual BatchDetail BatchDetail { get; set; } = null!;

    public virtual ContractActivity? ContractActivityNavigation { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual BatchDetail Inv { get; set; } = null!;

    public virtual CareItem? MeditemNavigation { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual MemberPlan MemberPlan { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
