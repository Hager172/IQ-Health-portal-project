using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalsTagsMap
{
    public int Id { get; set; }

    public long? ApprovalId { get; set; }

    public int? TagId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual Approval? Approval { get; set; }

    public virtual Tag? Tag { get; set; }
}
