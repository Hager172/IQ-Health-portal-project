using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsPharma
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double Price { get; set; }

    public string? Notes { get; set; }

    public string? PriceUpdateId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string Availability { get; set; } = null!;

    public string? Source { get; set; }

    public string? UnitSale { get; set; }

    public int? SubUnitNo { get; set; }

    public double? DoseUnitNo { get; set; }

    public string? DoseForm { get; set; }

    public int Active { get; set; }

    public DateTime? LastPriceDate { get; set; }

    public bool? Type { get; set; }

    public bool? IsMappingShow { get; set; }

    public string? HiddenReason { get; set; }

    public virtual ICollection<MedicineWithAlternative> MedicineWithAlternativeAlternatives { get; set; } = new List<MedicineWithAlternative>();

    public virtual ICollection<MedicineWithAlternative> MedicineWithAlternativeMedicines { get; set; } = new List<MedicineWithAlternative>();

    public virtual ICollection<OnlineMedDiagnose> OnlineMedDiagnoses { get; set; } = new List<OnlineMedDiagnose>();

    public virtual ICollection<SchApprovalService> SchApprovalServices { get; set; } = new List<SchApprovalService>();

    public virtual ICollection<OnlineRawMaterial> IdRaws { get; set; } = new List<OnlineRawMaterial>();
}
