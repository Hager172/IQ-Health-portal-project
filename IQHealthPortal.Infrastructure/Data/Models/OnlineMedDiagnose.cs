using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineMedDiagnose
{
    public int MedId { get; set; }

    public string DiaId { get; set; } = null!;

    public DateOnly? LastUpdateDate { get; set; }

    public string? LastUpdateByFrom { get; set; }

    public virtual OnlineDiagnosis Dia { get; set; } = null!;

    public virtual AcmsPharma Med { get; set; } = null!;
}
