using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SchApprovalService
{
    public long TempId { get; set; }

    public int ItemSerial { get; set; }

    public int ServiceId { get; set; }

    public int MedItem { get; set; }

    public double Qty { get; set; }

    public double Price { get; set; }

    public int? ItemRepeat { get; set; }

    public string? Notes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public double Coinsurance { get; set; }

    public double DoseUnits { get; set; }

    public int DoseRepeat { get; set; }

    public int DoseDuration { get; set; }

    public virtual CareItem MedItemNavigation { get; set; } = null!;

    public virtual AcmsPharma Service { get; set; } = null!;

    public virtual SchApproval Temp { get; set; } = null!;
}
