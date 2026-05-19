using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InstallmentBilldetail
{
    public int Serial { get; set; }

    public string InstallmentId { get; set; } = null!;

    public int ServiceId { get; set; }

    public double Value { get; set; }

    public double Discount { get; set; }

    public double OriginalPrice { get; set; }

    public string ContractId { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public string? Notes { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public double Tax { get; set; }

    public double? Qty { get; set; }

    public int CustomerId { get; set; }

    public virtual ContractInstallment Installment { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
