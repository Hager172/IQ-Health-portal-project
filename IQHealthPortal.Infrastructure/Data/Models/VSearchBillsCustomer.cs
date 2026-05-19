using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VSearchBillsCustomer
{
    public decimal BillId { get; set; }

    public DateTime? BillDate { get; set; }

    public short BillStatus { get; set; }

    public decimal? PaymentValue { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public decimal? BillSerial { get; set; }

    public string Col11 { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Insurer { get; set; }
}
