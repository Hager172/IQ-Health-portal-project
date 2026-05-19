using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAuthorizedApproval
{
    public long ActCode { get; set; }

    public DateTime Time { get; set; }

    public string Machine { get; set; } = null!;

    public string? AdditionalInfo { get; set; }

    public DateTime ApprovalDate { get; set; }

    public string MemberId { get; set; } = null!;

    public string? MemberName { get; set; }

    public double? TotalPrice { get; set; }

    public string? Notes { get; set; }

    public string? PrivateNotes { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? CurrentStatus { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? ContractId { get; set; }

    public double? BatchValue { get; set; }

    public decimal? BatchId { get; set; }

    public string? VendorName { get; set; }

    public string VendorId { get; set; } = null!;
}
