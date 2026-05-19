using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMcVendorsCatGovCity
{
    public string VindorId { get; set; } = null!;

    public int? Gov { get; set; }

    public string? GovName { get; set; }

    public int? City { get; set; }

    public int? Cat { get; set; }

    public int? SubCat { get; set; }

    public string? CityName { get; set; }

    public string? Spec { get; set; }
}
