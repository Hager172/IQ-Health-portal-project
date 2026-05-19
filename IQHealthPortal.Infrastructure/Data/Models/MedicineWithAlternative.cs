using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MedicineWithAlternative
{
    public int Id { get; set; }

    public int MedicineId { get; set; }

    public int AlternativeId { get; set; }

    public bool? IsAlternative { get; set; }

    public bool? IsDelete { get; set; }

    public virtual AcmsPharma Alternative { get; set; } = null!;

    public virtual AcmsPharma Medicine { get; set; } = null!;
}
