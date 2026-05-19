using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMashCareFullRefundView
{
    public int RequestId { get; set; }

    public long? ApprovalId { get; set; }

    public DateTime CreationDate { get; set; }

    public int Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public bool? RevFalg { get; set; }

    public bool? HasFile { get; set; }

    public string RiquestedBy { get; set; } = null!;

    public int? UserPlanPaymentId { get; set; }

    public int? DetailId { get; set; }

    public int? Serial { get; set; }

    public string? ServiceId { get; set; }

    public double? Price { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? RequestSource { get; set; }

    public string? VendorId { get; set; }

    public string? ApStatus { get; set; }

    public string? ApType { get; set; }

    public string? PlanCode { get; set; }

    public string? MemberId { get; set; }

    public string? MemberName { get; set; }

    public int? MemberCustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? VendorName { get; set; }

    public string? ServiceName { get; set; }

    public string? AdjNo { get; set; }

    public string? AdjStatus { get; set; }

    public string? Adjdate { get; set; }

    public decimal? Mony { get; set; }
}
