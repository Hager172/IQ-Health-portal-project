using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMcMemberConsumption
{
    public string? MainMemberId { get; set; }

    public string? MainMemberName { get; set; }

    public string? MainCustomerName { get; set; }

    public int? MainCustomerId { get; set; }

    public string FamilyMemberId { get; set; } = null!;

    public string FamilyMemberName { get; set; } = null!;

    public string? FamilyCustomerName { get; set; }

    public int? FamilyCustomerId { get; set; }

    public int? Id { get; set; }

    public int? UserPlanPaymentId { get; set; }

    public long? ApprovalId { get; set; }

    public int? PayType { get; set; }

    public string? PayStatus { get; set; }

    public DateTime? PayDate { get; set; }

    public double? PayValue { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? MerchantRefNum { get; set; }

    public int? PromoCodeId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public int? ServiceType { get; set; }

    public string? MemberId { get; set; }

    public int? UserPlanId { get; set; }

    public int? FollowerOrPlanId { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string LogNote { get; set; } = null!;

    public string? PaymentChannelName { get; set; }
}
