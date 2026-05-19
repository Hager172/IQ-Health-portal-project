using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineDiagnosisMain
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public int? Category { get; set; }

    public string? CareItem { get; set; }

    public string? Type { get; set; }

    public string? LinkId { get; set; }

    public virtual OnlineDiagnosis? Link { get; set; }
}
