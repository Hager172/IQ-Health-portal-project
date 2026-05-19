using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VWorklist
{
    public long ApprovalId { get; set; }

    public string MemberId { get; set; } = null!;

    public string? MemberName { get; set; }

    public string? ContractId { get; set; }

    public int? MemberCustomer { get; set; }

    public string? CustomerName { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? Notes { get; set; }

    public string? PrivateNotes { get; set; }

    public DateTime ApprovalDate { get; set; }

    public double? ServiceCoinsurance { get; set; }

    public double? ApprovalValue { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? ApStatus { get; set; }

    public string ApType { get; set; } = null!;

    public string? OnlineBCode { get; set; }

    public string? OnlineStatus { get; set; }

    public DateTime? OnlineLud { get; set; }

    public bool? MemberVip { get; set; }

    public bool? MemberEip { get; set; }

    public string? RequestSource { get; set; }

    public string? SourceFrom { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? IsPrinted { get; set; }

    public int? CountLog { get; set; }

    public int? Countmess { get; set; }
}
