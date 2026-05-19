using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorMedCareTemp
{
    public string VendormedcareId { get; set; } = null!;

    public bool VendorNbe { get; set; }

    public double VendorNbeNotes { get; set; }

    public bool VendorCarecard { get; set; }

    public string? VendorCarecardNotes { get; set; }

    public string? VendorOnlineUsername { get; set; }

    public bool VendorVip { get; set; }

    public string? BankName { get; set; }

    public string? VendorBankAccountNumber { get; set; }

    public string? VendormedcareClass { get; set; }

    public string? BankName2 { get; set; }

    public string? VendorBankAccountNumber2 { get; set; }

    public string? VendorNotes { get; set; }

    public string? VendorFinanNotes { get; set; }

    public bool? VendorAdvertiseFlag { get; set; }

    public string? Website { get; set; }

    public double? OpeningBalance { get; set; }

    public bool? HaveLabRad { get; set; }

    public bool? ServiceCash { get; set; }

    public bool BatchEnabled { get; set; }

    public virtual VendorGeneralTemp Vendormedcare { get; set; } = null!;
}
