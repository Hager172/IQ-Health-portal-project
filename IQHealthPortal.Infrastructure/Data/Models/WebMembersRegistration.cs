using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebMembersRegistration
{
    public long SerialId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BrithDate { get; set; }

    public string Gender { get; set; } = null!;

    public string MaritalStatus { get; set; } = null!;

    public double? Weight { get; set; }

    public double? Height { get; set; }

    public bool HasMedicine { get; set; }

    public string? MedicineNote { get; set; }

    public string? AllergyMedications { get; set; }

    public bool HasEverAnyInfection { get; set; }

    public string? InfectionNotes { get; set; }

    public string? OtherDiseases { get; set; }

    public string? AnySurgeries { get; set; }

    public bool IsSmoking { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Notes { get; set; }

    public virtual WebCustomerRequest Serial { get; set; } = null!;
}
