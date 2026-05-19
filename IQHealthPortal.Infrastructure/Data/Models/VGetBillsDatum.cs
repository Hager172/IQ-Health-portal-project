using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VGetBillsDatum
{
    public decimal BillId { get; set; }

    public DateTime? BillDate { get; set; }

    public int GroupId { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Insurer { get; set; }

    public string? CustomerAddress { get; set; }

    public DateTime? BillPeriodFrom { get; set; }

    public DateTime? BillPeriodTo { get; set; }

    public string? Notes { get; set; }

    public string? CustomerTaxCard { get; set; }
}
