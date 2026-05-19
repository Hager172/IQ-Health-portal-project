using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMembership
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public decimal? BillId { get; set; }

    public string MembershipState { get; set; } = null!;

    public DateTime? MemberSubDate { get; set; }

    public string CustomerName { get; set; } = null!;

    public bool MemberVip { get; set; }

    public bool? MemberEip { get; set; }

    public DateOnly? MemberBirthday { get; set; }

    public string MemberGender { get; set; } = null!;

    public string? MemberClass { get; set; }

    public string ContractCategoryName { get; set; } = null!;

    public string? ParentName { get; set; }

    public string? ParentId { get; set; }

    public string? MemberCareCardId { get; set; }

    public string? MemberCompanyId { get; set; }

    public string? MemberTele { get; set; }

    public string? MemberTele2 { get; set; }

    public string? MemberTele3 { get; set; }

    public string? MemberJob { get; set; }

    public string? MemberNotes { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public string MemberCustomer { get; set; } = null!;

    public DateTime? StoppedDate { get; set; }

    public string CardPrinted { get; set; } = null!;

    public DateTime CSubDate { get; set; }

    public DateTime ContractStart { get; set; }

    public DateTime ContractEnd { get; set; }

    public string Activity { get; set; } = null!;

    public int? SubMonths { get; set; }

    public double? BilledMonths { get; set; }
}
