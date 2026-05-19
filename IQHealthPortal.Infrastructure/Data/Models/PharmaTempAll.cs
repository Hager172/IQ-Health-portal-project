using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PharmaTempAll
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Arabic { get; set; }

    public string? Oldprice { get; set; }

    public decimal? Price { get; set; }

    public string? Active { get; set; }

    public string? Company { get; set; }

    public string? Description { get; set; }

    public string? Units { get; set; }

    public string? DosageForm { get; set; }

    public string? Barcode { get; set; }

    public string? Imported { get; set; }

    public string? DateUpdated { get; set; }

    public int? SoldTimes { get; set; }
}
