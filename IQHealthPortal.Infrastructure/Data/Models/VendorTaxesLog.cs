using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorTaxesLog
{
    public int Id { get; set; }

    public int TaxId { get; set; }

    public int ActionId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual Action Action { get; set; } = null!;

    public virtual VendorTaxis Tax { get; set; } = null!;
}
