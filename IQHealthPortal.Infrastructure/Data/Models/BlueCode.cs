using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BlueCode
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public double WarningValue { get; set; }

    public int Frequency { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
