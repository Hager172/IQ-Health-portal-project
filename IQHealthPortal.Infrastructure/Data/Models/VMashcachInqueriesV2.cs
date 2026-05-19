using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMashcachInqueriesV2
{
    public int ReqId { get; set; }

    public int? ReqSource { get; set; }

    public string? ReqMember { get; set; }

    public string? ReqProvider { get; set; }

    public int? ReqAddressId { get; set; }

    public DateTime? ReqDate { get; set; }

    public string? ReqStatus { get; set; }

    public int? ReqType { get; set; }

    public string? ReqNote { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? ReqCategory { get; set; }

    public string? ReqParent { get; set; }

    public string? MemberName { get; set; }

    public double Price { get; set; }

    public string? VendorName { get; set; }

    public long? ApprovalId { get; set; }

    public string? ApStatus { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? VendorCategoryName { get; set; }

    public string Url { get; set; } = null!;

    public string? ReferenceNumber { get; set; }

    public string? PayStatus { get; set; }

    public double? PayValue { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string SerName { get; set; } = null!;

    public int? AttachCount { get; set; }
}
