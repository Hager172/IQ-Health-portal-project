using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VVendorPayment
{
    public decimal FormNo { get; set; }

    public DateTime FormDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public DateTime? PayDate { get; set; }

    public string? SpendType { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorName { get; set; }

    public decimal? Val { get; set; }

    public decimal? Tax { get; set; }

    public decimal? AFees { get; set; }

    public string? OcNumber { get; set; }

    public DateTime? OcDueDate { get; set; }

    public string? VendorCheckBeneficiary { get; set; }

    public string? SbName { get; set; }

    public int? BankCode { get; set; }

    public short? OcType { get; set; }
}
