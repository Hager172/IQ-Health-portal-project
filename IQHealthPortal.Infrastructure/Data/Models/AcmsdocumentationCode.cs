using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsdocumentationCode
{
    public int Id { get; set; }

    public string ControllerName { get; set; } = null!;

    public string AcationName { get; set; } = null!;

    public string? Description { get; set; }

    public int? PageId { get; set; }

    public string? DataBaseObjects { get; set; }

    public bool? IsPartial { get; set; }

    public virtual ICollection<AcmsdocumentationCodeLog> AcmsdocumentationCodeLogs { get; set; } = new List<AcmsdocumentationCodeLog>();

    public virtual ICollection<AcmsdocumentationCode> DocCodeSubs { get; set; } = new List<AcmsdocumentationCode>();

    public virtual ICollection<AcmsdocumentationCode> DocCodes { get; set; } = new List<AcmsdocumentationCode>();
}
