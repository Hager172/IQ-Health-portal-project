using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomerConsumptionSummary
{
    public string? Name { get; set; }

    public string Contract { get; set; } = null!;

    public int? ActiveMembers { get; set; }

    public int? MembersWithConsumption { get; set; }

    public decimal? TotalIncome { get; set; }

    public decimal? IncomePerDay { get; set; }

    public double Consumption { get; set; }

    public double? Ratio { get; set; }

    public double? RatioStartToEnd { get; set; }

    public int? RemainingDays { get; set; }
}
