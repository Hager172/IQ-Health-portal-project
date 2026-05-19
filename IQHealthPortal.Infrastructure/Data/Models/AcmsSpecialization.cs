using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsSpecialization
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? Type { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<VendorDoctor> VendorDoctors { get; set; } = new List<VendorDoctor>();

    public virtual ICollection<VendorGeneral> Vendors { get; set; } = new List<VendorGeneral>();
}
