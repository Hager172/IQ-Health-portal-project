using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ProviderLog
{
    public int Id { get; set; }

    public string VendorId { get; set; } = null!;

    public int Action { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Note { get; set; }
}
