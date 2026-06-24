using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReportVwTaxPoliciesSimple
{
    public decimal StGccode { get; set; }

    public double Value { get; set; }

    public DateOnly? ExpireDate { get; set; }
}
