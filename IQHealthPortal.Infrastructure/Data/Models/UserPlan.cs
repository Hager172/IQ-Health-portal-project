using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserPlan
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int PlanId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime SubDate { get; set; }

    public DateTime CreationDate { get; set; }

    public double PaidValue { get; set; }

    public bool SubEnabled { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentId { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual SubscriptionPlan Plan { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;

    public virtual ICollection<PromoCode> Promos { get; set; } = new List<PromoCode>();
}
