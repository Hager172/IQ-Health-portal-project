using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsdocumentationCodeLog
{
    public int Id { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int DocCodeId { get; set; }

    public string? Notes { get; set; }

    public virtual AcmsdocumentationCode DocCode { get; set; } = null!;
}
