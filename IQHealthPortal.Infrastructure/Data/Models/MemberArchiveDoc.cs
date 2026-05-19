using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberArchiveDoc
{
    public string MemberId { get; set; } = null!;

    public int CatId { get; set; }

    public int Serial { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? FileExtension { get; set; }

    public virtual VendorCategory Cat { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
