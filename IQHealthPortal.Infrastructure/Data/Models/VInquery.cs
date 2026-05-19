using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VInquery
{
    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? ReqAddressId { get; set; }

    public int? ReqCategory { get; set; }

    public DateTime? ReqDate { get; set; }

    public int ReqId { get; set; }

    public string? ReqMember { get; set; }

    public string? ReqNote { get; set; }

    public string? ReqParent { get; set; }

    public string? ReqProvider { get; set; }

    public int? ReqSource { get; set; }

    public string? ReqStatus { get; set; }

    public int? ReqType { get; set; }

    public string? Status { get; set; }

    public long? ApprovalId { get; set; }

    public string? MemberId { get; set; }

    public string? AppLastUpdateBy { get; set; }

    public DateTime? AppLastUpdateDate { get; set; }

    public string? MemberName { get; set; }

    public string? VendorId { get; set; }

    public string? VendorName { get; set; }

    public string? OnlineBName { get; set; }

    public string? MemberAddress { get; set; }

    public double? ApprovalValue { get; set; }

    public string? OnlineBCode { get; set; }

    public string? OnlineStatus { get; set; }

    public string? CustomerName { get; set; }

    public double? ApprovalMcValue { get; set; }
}
