using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorsVisit
{
    public int VisitId { get; set; }

    public string VendorId { get; set; } = null!;

    public DateTime? VisitDate { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? IsCalling { get; set; }

    public virtual ICollection<UsersVendorsVisit> UsersVendorsVisits { get; set; } = new List<UsersVendorsVisit>();

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
