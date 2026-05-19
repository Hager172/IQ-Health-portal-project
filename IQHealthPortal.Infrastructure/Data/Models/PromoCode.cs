using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PromoCode
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public double Value { get; set; }

    public int MaxNo { get; set; }

    public int Type { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual ICollection<UserPlan> Subscriptions { get; set; } = new List<UserPlan>();
}
