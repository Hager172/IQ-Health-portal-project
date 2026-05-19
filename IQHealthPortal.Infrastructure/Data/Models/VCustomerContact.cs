using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomerContact
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? CustomerContactPerson { get; set; }

    public string CustomerMobile { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerWebsite { get; set; } = null!;

    public string Satus { get; set; } = null!;
}
