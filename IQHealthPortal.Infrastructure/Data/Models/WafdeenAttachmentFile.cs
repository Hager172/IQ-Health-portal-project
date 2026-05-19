using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WafdeenAttachmentFile
{
    public int Id { get; set; }

    public int? VisitId { get; set; }

    public string? Label { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? DocumentName { get; set; }

    public virtual WafdeenVisit? Visit { get; set; }
}
