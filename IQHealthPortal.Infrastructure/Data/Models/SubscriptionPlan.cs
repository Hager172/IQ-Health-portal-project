using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SubscriptionPlan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public short Months { get; set; }

    public string? Notes { get; set; }

    public int Followers { get; set; }

    public DateTime CreationDate { get; set; }

    public string Status { get; set; } = null!;

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int Type { get; set; }

    public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();
}
