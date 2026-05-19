using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TaxPolicy
{
    public int Id { get; set; }

    public double Value { get; set; }

    public DateOnly? ExpireDate { get; set; }
}
