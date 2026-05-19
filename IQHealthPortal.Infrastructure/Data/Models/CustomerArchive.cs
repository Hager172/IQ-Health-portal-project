using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerArchive
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CustomerId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<CustomerContract> CustomerContracts { get; set; } = new List<CustomerContract>();
}
