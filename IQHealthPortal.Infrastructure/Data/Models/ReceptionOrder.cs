using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ReceptionOrder
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? VendorId { get; set; }

    public string? Notes { get; set; }

    public string Address { get; set; } = null!;

    public int? CountryId { get; set; }

    public int? AreaId { get; set; }

    public int Status { get; set; }

    public DateTime DeliveryTime { get; set; }

    public bool Periorty { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string LastUpdatedBy { get; set; } = null!;

    public int RequiredTaskId { get; set; }

    public int? DocumentType { get; set; }

    public int Number { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<AssginOrder> AssginOrders { get; set; } = new List<AssginOrder>();

    public virtual Area? Country { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual DocumentType? DocumentTypeNavigation { get; set; }

    public virtual ICollection<OrderLocation> OrderLocations { get; set; } = new List<OrderLocation>();

    public virtual RequiredTask RequiredTask { get; set; } = null!;

    public virtual Status StatusNavigation { get; set; } = null!;

    public virtual VendorGeneral? Vendor { get; set; }
}
