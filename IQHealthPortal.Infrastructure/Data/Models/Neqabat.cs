using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Neqabat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? Type { get; set; }

    public virtual VendorCategory Category { get; set; } = null!;

    public virtual ICollection<VendorFixedService> VendorFixedServices { get; set; } = new List<VendorFixedService>();
}
