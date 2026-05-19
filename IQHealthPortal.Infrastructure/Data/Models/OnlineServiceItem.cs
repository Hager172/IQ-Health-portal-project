using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineServiceItem
{
    public long ServiceId { get; set; }

    public string NameAr { get; set; } = null!;

    public string? NameEn { get; set; }

    public string? Abbreviation { get; set; }

    public decimal? ServiceType { get; set; }

    public string? Availabilty { get; set; }
}
