using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string TagText { get; set; } = null!;

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual ICollection<ApprovalsTagsMap> ApprovalsTagsMaps { get; set; } = new List<ApprovalsTagsMap>();
}
