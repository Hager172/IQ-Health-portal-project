using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMashCareRefundSummary
{
    public int RefundReqestId { get; set; }

    public long? ApprovalId { get; set; }

    public string? MemberName { get; set; }

    public string? MemberId { get; set; }

    public string? CustomerName { get; set; }

    public string? VendorName { get; set; }

    public DateTime CreationDate { get; set; }

    public string? ServiceName { get; set; }

    public double? ServicePrice { get; set; }

    public string WrittenBy { get; set; } = null!;

    public string? ApType { get; set; }

    public int? CustomerId { get; set; }

    public int StatusRequest { get; set; }

    public string? ApStatus { get; set; }

    public double Wallet { get; set; }

    public double Fawry { get; set; }

    public string? RefurenceNumber { get; set; }

    public bool? RevFlag { get; set; }

    public string? AdjNo { get; set; }

    public string? AdjStatus { get; set; }

    public string? Adjdate { get; set; }

    public bool? HasFile { get; set; }

    public int? UserPlanId { get; set; }
}
