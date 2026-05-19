using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerVendorException
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string VendorId { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
