using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VSudanGroupsSummary
{
    public string? ContractCode { get; set; }

    public int Id { get; set; }

    public DateTime GroupStart { get; set; }

    public double? ValEgp { get; set; }

    public int? CollectionsEgp { get; set; }
}
