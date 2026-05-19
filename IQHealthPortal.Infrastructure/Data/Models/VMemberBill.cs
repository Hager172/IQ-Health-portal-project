using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMemberBill
{
    public int BillId { get; set; }

    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public double Value { get; set; }

    public int? AnnualFees { get; set; }
}
