using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContactsTemp
{
    public int ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public string? ContactEmail { get; set; }

    public string ContactVendorId { get; set; } = null!;

    public string? ContactTele { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int ContactOccupationId { get; set; }

    public string? ContactNotes { get; set; }

    public string? ContactTele2 { get; set; }

    public virtual ContactsOccupation ContactOccupation { get; set; } = null!;

    public virtual VendorGeneralTemp ContactVendor { get; set; } = null!;
}
