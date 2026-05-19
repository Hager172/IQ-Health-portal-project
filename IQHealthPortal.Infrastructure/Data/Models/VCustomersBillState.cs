using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomersBillState
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerContractId { get; set; } = null!;

    public string? PaymentType { get; set; }

    public DateOnly InstallmentDate { get; set; }

    public decimal? BillId { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BillValue { get; set; }

    public decimal? Collected { get; set; }

    public decimal? Balance { get; set; }

    public string ContractType { get; set; } = null!;

    public int? InsurerId { get; set; }

    public string? InsurerName { get; set; }
}
