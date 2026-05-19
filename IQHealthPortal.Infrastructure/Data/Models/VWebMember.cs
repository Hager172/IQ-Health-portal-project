using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VWebMember
{
    public long MemberId { get; set; }

    public string? Name { get; set; }

    public DateTime? Birthdate { get; set; }

    public DateTime? EntryDate { get; set; }

    public string MemberStatus { get; set; } = null!;

    public string? MemberCreatedBy { get; set; }

    public string? StEmpId { get; set; }

    public string? Phone { get; set; }

    public string? CurrencyType { get; set; }

    public string? MemberCustomer { get; set; }

    public long MemberItemId { get; set; }

    public long Item { get; set; }

    public long Member { get; set; }

    public string? ItemComment { get; set; }

    public DateTime? ItemDate { get; set; }

    public string? ItemStatus { get; set; }

    public string? ItemCreatedBy { get; set; }

    public double? CoverageLimit { get; set; }

    public string? ResposeBy { get; set; }

    public string? ItemCurrency { get; set; }

    public string? ItemCustomer { get; set; }

    public string UserId { get; set; } = null!;

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public string? DefaultCustomer { get; set; }

    public long ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNameAr { get; set; }

    public string? ItemNameFr { get; set; }

    public bool Enable { get; set; }

    public string? CareItemComment { get; set; }
}
