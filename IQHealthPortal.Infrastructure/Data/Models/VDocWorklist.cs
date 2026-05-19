using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VDocWorklist
{
    public string? FormId { get; set; }

    public int? VendorCategoryId { get; set; }

    public double Value { get; set; }
}
