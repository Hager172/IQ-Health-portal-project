using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineDiagnoseCategory
{
    public string CatName { get; set; } = null!;

    public int Id { get; set; }

    public virtual ICollection<OnlineDiagnosis> OnlineDiagnoses { get; set; } = new List<OnlineDiagnosis>();
}
