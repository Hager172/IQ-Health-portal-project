using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomerNationalOrNotCount
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int? MemberhasNid { get; set; }

    public int? MemberNoNid { get; set; }
}
