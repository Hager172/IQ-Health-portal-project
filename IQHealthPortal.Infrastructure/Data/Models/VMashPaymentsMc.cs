using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMashPaymentsMc
{
    public int Id { get; set; }

    public int? UserPlanPaymentId { get; set; }

    public long? ApprovalId { get; set; }

    public int PayType { get; set; }

    public string PayStatus { get; set; } = null!;

    public DateTime? PayDate { get; set; }

    public double PayValue { get; set; }

    public DateTime ExpireDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public string? MerchantRefNum { get; set; }

    public int? PromoCodeId { get; set; }

    public DateTime CreationDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public int ServiceType { get; set; }

    public string? MemberId { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? UserPlanId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? Notes { get; set; }

    public string? MembId { get; set; }
}
