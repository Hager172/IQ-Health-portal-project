using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractBroker
{
    public int Id { get; set; }

    public string ContractId { get; set; } = null!;

    public int BrokerId { get; set; }

    public int? Percentage { get; set; }

    public int? Val { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual Broker Broker { get; set; } = null!;

    public virtual CustomerContract Contract { get; set; } = null!;
}
