using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineItemCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<OnlineDiagnosis> OnlineDiagnoses { get; set; } = new List<OnlineDiagnosis>();

    public virtual ICollection<CareItem> Iids { get; set; } = new List<CareItem>();
}
