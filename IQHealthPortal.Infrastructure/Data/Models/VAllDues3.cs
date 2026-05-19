using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VAllDues3
{
    public decimal Batchid { get; set; }

    public int? InvNumbers { get; set; }

    public double? MedDiscount { get; set; }

    public double? LocDiscount { get; set; }

    public double? BatchCost { get; set; }

    public DateOnly BatchReceivedDate { get; set; }

    public bool BatchMedicalFlag { get; set; }

    public bool BatchFinancialFlag { get; set; }

    public string? BatchStatus { get; set; }

    public string BatchVendorId { get; set; } = null!;

    public double ReceivedCost { get; set; }

    public int BatchNumber { get; set; }

    public double VendorContractAdministrativeDiscount { get; set; }

    public double? XtraValue { get; set; }

    public string XtraNote { get; set; } = null!;

    public decimal Paid { get; set; }

    public string? VendorName { get; set; }

    public string ChequeName { get; set; } = null!;

    public string? Area { get; set; }

    public string? Gov { get; set; }

    public decimal? Tax { get; set; }

    public int VendorPayPeriod { get; set; }

    public DateOnly? DueDate { get; set; }

    public string? BankName { get; set; }

    public string? VendorBankAccountNumber { get; set; }

    public string? VendorCheckBeneficiary { get; set; }

    public DateTime? PayDate { get; set; }

    public decimal? Cheque { get; set; }
}
