using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VCustomerAllBill
{
    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerEmail { get; set; }

    public string? CustomerContractId { get; set; }

    public string? PaymentType { get; set; }

    public DateOnly? InstallmentDate { get; set; }

    public DateOnly? BillDate { get; set; }

    public string? BillStatus { get; set; }

    public decimal? BillValue { get; set; }

    public decimal? Collected { get; set; }

    public decimal? Balance { get; set; }

    public string? InstallmentId { get; set; }

    public string? ContractType { get; set; }

    public double? InstallmentValue { get; set; }

    public int HasBill { get; set; }

    public int? Billid { get; set; }

    public decimal? AccBillId { get; set; }

    public DateTime? BillCreatedDate { get; set; }
}
