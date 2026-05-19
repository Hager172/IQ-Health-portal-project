using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VitalSignsMember
{
    public int Id { get; set; }

    public string? MemberId { get; set; }

    public int? VitalCategory { get; set; }

    public string? Reading { get; set; }

    public string? Notes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime? LastUpdateDate { get; set; }

    public virtual Member? Member { get; set; }

    public virtual VitalSign? VitalCategoryNavigation { get; set; }
}
