using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VInsuranceCompaniesReport
{
    public string? Insurer { get; set; }

    public string Currency { get; set; } = null!;

    public DateOnly AdmissionDate { get; set; }

    public string PoolStatus { get; set; } = null!;

    public double? Celling { get; set; }

    public string SubCelling { get; set; } = null!;

    public string Retention { get; set; } = null!;

    public int Fob { get; set; }

    public string MasterContractName { get; set; } = null!;

    public string PolicyName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string ProviderType { get; set; } = null!;

    public string? ProviderName { get; set; }

    public string? PatientName { get; set; }

    public int? CardNumber { get; set; }

    public int? POIdPaymentOrder { get; set; }

    public string? Status { get; set; }

    public string? SpecificAssessment { get; set; }

    public double EstCost { get; set; }

    public double Claimed { get; set; }

    public double Approved { get; set; }

    public double BShare { get; set; }

    public double Denied { get; set; }

    public double Discount { get; set; }

    public int OtherDiscounts { get; set; }

    public double InLocal { get; set; }

    public string BcShare { get; set; } = null!;

    public DateOnly? ProcessedDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public DateOnly? DisChargeDate { get; set; }

    public string DeliveryDate { get; set; } = null!;

    public string ProviderShequeSent { get; set; } = null!;

    public string? Product { get; set; }

    public string? ProductClass { get; set; }

    public decimal? BatchId { get; set; }

    public string? PrincipalFristName { get; set; }

    public DateOnly? Dob { get; set; }

    public string Nationality { get; set; } = null!;

    public string MedicalNote { get; set; } = null!;

    public string NotUsed { get; set; } = null!;

    public int Pending { get; set; }

    public string ContractType { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public int NotCoveredCharges { get; set; }

    public double PureClaimValue { get; set; }

    public double PureClaimValueInLocCurr { get; set; }

    public double NetClaimValue { get; set; }

    public string ClaimSource { get; set; } = null!;

    public string Validated { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? DischargeMonth { get; set; }

    public double InvoiceAmount { get; set; }

    public DateTime PolicyInceptionDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int? UY { get; set; }

    public long ClaimKey { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string IsElectronic { get; set; } = null!;

    public decimal? Ref { get; set; }

    public int? InsurerId { get; set; }
}
