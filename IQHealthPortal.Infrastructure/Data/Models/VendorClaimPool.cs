using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorClaimPool
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual ICollection<VendorGeneral> Vendors { get; set; } = new List<VendorGeneral>();
}
