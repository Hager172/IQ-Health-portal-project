using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PharmaMigration
{
    public double? VId { get; set; }

    public string? VName { get; set; }

    public double? VPacksize { get; set; }

    public string? VPackunit { get; set; }

    public double? VPrice { get; set; }

    public double? MId { get; set; }

    public string? MName { get; set; }

    public string? MNote { get; set; }
}
