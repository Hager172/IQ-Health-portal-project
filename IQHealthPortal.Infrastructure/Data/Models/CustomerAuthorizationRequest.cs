using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerAuthorizationRequest
{
    public int Id { get; set; }

    public string RequestUserId { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreationDate { get; set; }

    public string? ResponseUserId { get; set; }

    public DateTime? ResponseDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Note { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual AspNetUser RequestUser { get; set; } = null!;

    public virtual AspNetUser? ResponseUser { get; set; }
}
