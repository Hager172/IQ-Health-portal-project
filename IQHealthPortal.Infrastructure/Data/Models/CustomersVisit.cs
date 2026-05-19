using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomersVisit
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime VisitDate { get; set; }

    public string? Notes { get; set; }

    public DateTime CreationDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
