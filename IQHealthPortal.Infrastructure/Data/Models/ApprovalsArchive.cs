using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalsArchive
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Path { get; set; } = null!;

    public long ApprovalId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public int? AttachedNameId { get; set; }

    public string? FormCategories { get; set; }

    public virtual Approval Approval { get; set; } = null!;

    public virtual AttachedDocumentName? AttachedName { get; set; }
}
