using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OrderLocation
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? StartOrgLang { get; set; }

    public string? StartOrgLat { get; set; }

    public DateTime? StartOrgDate { get; set; }

    public string? ArriveOrderLang { get; set; }

    public string? ArriveOrderLat { get; set; }

    public DateTime? ArriveOrderDate { get; set; }

    public string? LeaveOrderLang { get; set; }

    public string? LeaveOrderLat { get; set; }

    public DateTime? LeaveOrderDate { get; set; }

    public string? EndOrgLang { get; set; }

    public string? EndOrgLat { get; set; }

    public DateTime? EndOrgDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int? Status { get; set; }

    public virtual ReceptionOrder Order { get; set; } = null!;

    public virtual Status? StatusNavigation { get; set; }
}
