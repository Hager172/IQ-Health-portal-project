using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberPlanTemp
{
    public string MemberCode { get; set; } = null!;

    public string PlanCode { get; set; } = null!;

    public int MamberPlanFinancialPlan { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string CardPrinted { get; set; } = null!;

    public string ContractCode { get; set; } = null!;

    public string? Status { get; set; }

    public int? OperationCode { get; set; }
}
