using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OrderReceptionDestination
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public string? Destination { get; set; }
}
