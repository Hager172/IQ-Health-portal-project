using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AttachedDocumentName
{
    public int AttachedDocId { get; set; }

    public string AttachedDocName { get; set; } = null!;

    public virtual ICollection<ApprovalsArchive> ApprovalsArchives { get; set; } = new List<ApprovalsArchive>();
}
