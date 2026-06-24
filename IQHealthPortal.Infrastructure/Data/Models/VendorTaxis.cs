using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorTaxis
{
    public int Id { get; set; }

    public string VendorId { get; set; } = null!;

    public bool? HasNoTax { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual ICollection<VendorTaxesLog> VendorTaxesLogs { get; set; } = new List<VendorTaxesLog>();
}
