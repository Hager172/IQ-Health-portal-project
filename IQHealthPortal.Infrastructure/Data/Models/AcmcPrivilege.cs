using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmcPrivilege
{
    public string UserId { get; set; } = null!;

    public int PageId { get; set; }

    public bool? PrevView { get; set; }

    public bool? PrevAdd { get; set; }

    public bool? PrevEdit { get; set; }

    public bool? PrevSubmit { get; set; }

    public bool? PrevUnsubmit { get; set; }

    public bool? PrevCancel { get; set; }

    public bool? PrevImport { get; set; }

    public bool? PrevExport { get; set; }

    public bool? PrevPrint { get; set; }

    public bool? PrevSpacialcase { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
