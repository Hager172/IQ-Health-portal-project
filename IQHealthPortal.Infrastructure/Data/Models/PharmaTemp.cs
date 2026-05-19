using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PharmaTemp
{
    public string Code { get; set; } = null!;

    public string? DrugName { get; set; }

    public string? UnitOfSale { get; set; }

    public double? NoOfUnits { get; set; }

    public double? Price { get; set; }

    public string? DosageForm { get; set; }

    public string? Category { get; set; }

    public string? Genericname { get; set; }

    public int? SmallUnit { get; set; }
}
