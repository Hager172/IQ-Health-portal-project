using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMembersContractPremium
{
    public decimal BillId { get; set; }

    public string? MemberId { get; set; }

    public string MemberName { get; set; } = null!;

    public string? Contract { get; set; }

    public string? Customer { get; set; }

    public decimal? PatientPrice { get; set; }

    public DateTime? Date { get; set; }

    public int? AnnualFees { get; set; }
}
