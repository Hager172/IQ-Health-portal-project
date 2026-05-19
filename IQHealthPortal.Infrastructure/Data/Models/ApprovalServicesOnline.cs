using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ApprovalServicesOnline
{
    public long ApprovalId { get; set; }

    public int ItemSerial { get; set; }

    public int ServiceId { get; set; }

    public int? MedItem { get; set; }

    public double? Qty { get; set; }

    public double? Price { get; set; }

    public string? ItemDesc { get; set; }

    public bool? IsChronic { get; set; }

    public int? ItemRepeat { get; set; }

    public string? Notes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? InsurerMeditem { get; set; }

    public double? Coinsurance { get; set; }

    public string? OnlineStatus { get; set; }

    public int? Days { get; set; }

    public double? ApQty { get; set; }

    public int? DoseDurType { get; set; }

    public int? MinUnits { get; set; }

    public double? DoseUnits { get; set; }

    public int? DoseRepeat { get; set; }

    public int? DoseDuration { get; set; }

    public double? OriginalPrice { get; set; }

    public int? Editqty { get; set; }
}
