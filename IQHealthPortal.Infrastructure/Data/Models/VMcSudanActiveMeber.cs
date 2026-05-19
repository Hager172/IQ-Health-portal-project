using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMcSudanActiveMeber
{
    public string MemberName { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public string? MemberNationalId { get; set; }

    public string ContractCode { get; set; } = null!;

    public string PlanCode { get; set; } = null!;

    public int VisitId { get; set; }
}
