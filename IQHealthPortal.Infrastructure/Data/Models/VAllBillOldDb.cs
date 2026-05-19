using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAllBillOldDb
{
    public decimal BillId { get; set; }

    public string BillCat { get; set; } = null!;

    public string SaEmpid { get; set; } = null!;

    public decimal? SaRcode { get; set; }

    public int SaSerial { get; set; }

    public short BillStatus { get; set; }

    public string SrvCode { get; set; } = null!;

    public double? Price { get; set; }

    public DateTime? BillDate { get; set; }

    public string? CustomerId { get; set; }

    public string? ContractId { get; set; }

    public decimal? ExpensesBillId { get; set; }
}
