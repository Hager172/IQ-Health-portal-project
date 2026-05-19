using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VSubscriptionAnalysis
{
    public int? Premium { get; set; }

    public int? InstallmentsNumber { get; set; }

    public DateTime? SubscriptionDate { get; set; }

    public DateTime PolicyStartDate { get; set; }

    public DateOnly? Dob { get; set; }

    public string CardType { get; set; } = null!;

    public string? PolicyType { get; set; }

    public string MemberId { get; set; } = null!;

    public string PolicyId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;
}
