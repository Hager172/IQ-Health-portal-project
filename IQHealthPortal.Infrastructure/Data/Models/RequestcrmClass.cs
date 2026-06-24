using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class RequestcrmClass
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public string? Class { get; set; }

    public int? MembersCount { get; set; }

    public virtual RequestcrmCustomer Request { get; set; } = null!;
}
