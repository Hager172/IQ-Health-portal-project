using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberPlanLog
{
    public int Id { get; set; }

    public string MemberCode { get; set; } = null!;

    public string? PlanId { get; set; }

    public string? NewPlanId { get; set; }

    public int? FinancialPlan { get; set; }

    public string? ContractCode { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;
}
