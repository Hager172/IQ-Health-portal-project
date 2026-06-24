using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorAgreementHistory
{
    public long Id { get; set; }

    public string VendorId { get; set; } = null!;

    public string? TaxId { get; set; }

    public DateOnly StartContract { get; set; }

    public DateOnly? EndContract { get; set; }

    public string? LastUpDateBy { get; set; }

    public DateTime? LastUpDateDate { get; set; }

    public string? LastUpDateFrom { get; set; }
}
