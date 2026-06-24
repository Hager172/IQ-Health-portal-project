using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string Status1 { get; set; } = null!;

    public virtual ICollection<AssginOrderLog> AssginOrderLogs { get; set; } = new List<AssginOrderLog>();

    public virtual ICollection<AssginOrder> AssginOrders { get; set; } = new List<AssginOrder>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual ICollection<OrderLocation> OrderLocations { get; set; } = new List<OrderLocation>();

    public virtual ICollection<ReceptionOrder> ReceptionOrders { get; set; } = new List<ReceptionOrder>();
}
