using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class StateRef
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? NameE { get; set; }

    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
