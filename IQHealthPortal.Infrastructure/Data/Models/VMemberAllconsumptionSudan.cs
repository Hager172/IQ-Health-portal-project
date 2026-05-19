using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMemberAllconsumptionSudan
{
    public double LocalDis { get; set; }

    public double ImportDis { get; set; }

    public long InvId { get; set; }

    public bool? Notified { get; set; }

    public int Serial { get; set; }

    public string VendorId { get; set; } = null!;

    public string? ContractCode { get; set; }

    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public int MemberCustomerId { get; set; }

    public string? VendorName { get; set; }

    public string? ServiceName { get; set; }

    public string? CareItemName { get; set; }

    public decimal BatchId { get; set; }

    public DateOnly ServiceDate { get; set; }

    public double Value { get; set; }

    public double RevDis { get; set; }

    public double CoPayment { get; set; }

    public double Net { get; set; }

    public double ContractDis { get; set; }

    public string? CustomerContractCategory { get; set; }

    public long ApprovalNumber { get; set; }

    public string? BatchStatus { get; set; }
}
