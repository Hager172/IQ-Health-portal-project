using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VSrvAnalisi
{
    public string Type { get; set; } = null!;

    public double Value { get; set; }

    public double CoPayment { get; set; }

    public double ContractDiscount { get; set; }

    public double MedicalDiscount { get; set; }

    public double Net { get; set; }

    public DateTime PaymentDate { get; set; }

    public DateOnly ReceivedDate { get; set; }

    public DateOnly ServiceDate { get; set; }

    public string? Gov { get; set; }

    public string Area { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? ServiceType { get; set; }

    public string ServiceItem { get; set; } = null!;

    public DateTime PolicyStartDate { get; set; }

    public DateOnly? MemberBirthday { get; set; }

    public string CardType { get; set; } = null!;

    public string? PolicyType { get; set; }

    public string MemberId { get; set; } = null!;

    public int CompanyId { get; set; }

    public string? PolicyId { get; set; }

    public string? InvId { get; set; }
}
