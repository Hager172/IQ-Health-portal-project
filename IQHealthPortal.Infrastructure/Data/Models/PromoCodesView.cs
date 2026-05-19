using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PromoCodesView
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int? SubPlan { get; set; }

    public string? SubPlanName { get; set; }

    public double Value { get; set; }

    public string? ValueType { get; set; }

    public int MaxNo { get; set; }

    public int Type { get; set; }

    public string Status { get; set; } = null!;

    public int? Target { get; set; }

    public string? TargetName { get; set; }

    public int? Source { get; set; }

    public string? SourceName { get; set; }

    public int? EmployeeBroker { get; set; }

    public string? BrokerName { get; set; }

    public decimal? BrokerValue { get; set; }

    public string? BrokerValueType { get; set; }

    public string? TargetPlan { get; set; }

    public DateTime CreationDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
