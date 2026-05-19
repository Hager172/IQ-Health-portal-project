using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineRawMaterial
{
    public int Id { get; set; }

    public string? RawMaterial { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<OnlineDiagnosis> IdDiagnoses { get; set; } = new List<OnlineDiagnosis>();

    public virtual ICollection<AcmsPharma> IdMeds { get; set; } = new List<AcmsPharma>();
}
