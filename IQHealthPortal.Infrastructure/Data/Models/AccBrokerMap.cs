using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccBrokerMap
{
    public int Id { get; set; }

    public int BrokerId { get; set; }

    public string? MemberId { get; set; }

    public string BrokerName { get; set; } = null!;

    public int AccCode { get; set; }

    public string AccName { get; set; } = null!;

    public string AccDeptId { get; set; } = null!;

    public string? AccDeptName { get; set; }
}
