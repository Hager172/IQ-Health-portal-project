using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VReimpWorklist
{
    public decimal BatchId { get; set; }

    public DateOnly BatchReceivedDate { get; set; }

    public decimal Paid { get; set; }

    public int CustomerId { get; set; }

    public double? BatchCost { get; set; }

    public double? Dis { get; set; }

    public double? XtraValue { get; set; }

    public double? Net { get; set; }

    public int Credit { get; set; }

    public DateOnly Debtindays { get; set; }

    public string MemberName { get; set; } = null!;

    public int? ND { get; set; }

    public bool BatchMedicalFlag { get; set; }

    public string? MedicallyRevisedBy { get; set; }

    public bool BatchFinancialFlag { get; set; }

    public string? BatchStatus { get; set; }

    public string? CurrentStep { get; set; }

    public int? BatchInvoiceNumber { get; set; }

    public string? ContractCode { get; set; }

    public string CustomerName { get; set; } = null!;

    public int MainCustomerId { get; set; }

    public int Splited { get; set; }

    public string PayInfo { get; set; } = null!;
}
