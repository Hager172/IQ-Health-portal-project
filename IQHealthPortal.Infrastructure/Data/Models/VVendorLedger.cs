using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorLedger
{
    public string? SupplierCode { get; set; }

    public decimal ActionCode { get; set; }

    public int? ActiontypeCode { get; set; }

    public int ActionEffect { get; set; }

    public DateTime? ActionDate { get; set; }

    public decimal Debit { get; set; }

    public double? Credit { get; set; }

    public string? ActionDescription { get; set; }

    public string? ExtCode { get; set; }

    public string? DocNo { get; set; }

    public string? ActionNotes { get; set; }
}
