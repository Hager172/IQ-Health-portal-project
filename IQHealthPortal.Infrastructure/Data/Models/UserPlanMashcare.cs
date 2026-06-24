using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserPlanMashcare
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? MemberId { get; set; }

    public string? MemberName { get; set; }

    public string? MemberClass { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? PlanName { get; set; }

    public int? PromoCodeId { get; set; }

    public double? PaidValue { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime SubDate { get; set; }

    public int NoOfApprovals { get; set; }

    public int? NoFollowers { get; set; }

    public string? PlanCode { get; set; }
}
