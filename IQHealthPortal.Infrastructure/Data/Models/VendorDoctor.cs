using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorDoctor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Degree { get; set; }

    public int SpecializationId { get; set; }

    public string VendorId { get; set; } = null!;

    public bool Status { get; set; }

    public int? Type { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual AcmsSpecialization Specialization { get; set; } = null!;

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
