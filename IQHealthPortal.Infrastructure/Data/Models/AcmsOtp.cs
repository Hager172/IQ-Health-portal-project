using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsOtp
{
    public int Id { get; set; }

    public string Password { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string SendTo { get; set; } = null!;

    public string? UsedBy { get; set; }

    public virtual Customer? Customer { get; set; }
}
