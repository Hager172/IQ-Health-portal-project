using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VApprovalsDatum
{
    public long ApprovalId { get; set; }

    public string? ApStatus { get; set; }

    public string ApType { get; set; } = null!;

    public DateTime ApprovalDate { get; set; }

    public double? Coinsurance { get; set; }

    public string? Currentip { get; set; }

    public DateOnly? FormDate { get; set; }

    public string? FormId { get; set; }

    public string? IsOnline { get; set; }

    public bool? Isnotified { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public long? MainApproval { get; set; }

    public double? MaxValue { get; set; }

    public string MemberId { get; set; } = null!;

    public string? Notes { get; set; }

    public string? OnlineBCode { get; set; }

    public DateTime? OnlineLud { get; set; }

    public string? OnlineStatus { get; set; }

    public string? OnlineUser { get; set; }

    public long? ParentApproval { get; set; }

    public string? PlanCode { get; set; }

    public string? PrivateNotes { get; set; }

    public string? RequestSource { get; set; }

    public string VendorId { get; set; } = null!;

    public double? ApQty { get; set; }

    public double? ServiceCoinsurance { get; set; }

    public double? SumCoinsurance { get; set; }

    public int? Days { get; set; }

    public int? DoseDurType { get; set; }

    public int? DoseDuration { get; set; }

    public int? DoseRepeat { get; set; }

    public double? DoseUnits { get; set; }

    public int? Editqty { get; set; }

    public int? InsurerMeditem { get; set; }

    public bool? IsChronic { get; set; }

    public string? ItemDesc { get; set; }

    public int? ItemRepeat { get; set; }

    public int? ItemSerial { get; set; }

    public string? ServiceUpdateBy { get; set; }

    public DateTime? ServiceUpdateDate { get; set; }

    public string? ServiceUpdateFrom { get; set; }

    public int? MedItem { get; set; }

    public int? MinUnits { get; set; }

    public string? ServiceNotes { get; set; }

    public string? ServiceOnlineStatus { get; set; }

    public double? OriginalPrice { get; set; }

    public double? Price { get; set; }

    public double? Qty { get; set; }

    public int? ServiceId { get; set; }

    public double? ApprovalValue { get; set; }

    public string? MemberName { get; set; }

    public int? ParnetCustomer { get; set; }

    public int? MemberCustomer { get; set; }

    public string? CustomerName { get; set; }

    public string? ParentCustomerName { get; set; }

    public string? ContractId { get; set; }

    public string? VendorName { get; set; }

    public bool? MemberVip { get; set; }

    public bool? MemberEip { get; set; }
}
