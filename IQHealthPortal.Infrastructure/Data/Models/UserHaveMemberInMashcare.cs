using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserHaveMemberInMashcare
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? MemberName { get; set; }

    public string? MemberTele { get; set; }

    public string? MemberEmail { get; set; }

    public int? PromoCodeId { get; set; }

    public double? PaidValue { get; set; }

    public DateTime? LastPaymentDate { get; set; }

    public int? SubscriptionPlanId { get; set; }

    public string? PlanName { get; set; }
}
