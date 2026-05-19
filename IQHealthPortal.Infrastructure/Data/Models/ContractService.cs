using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractService
{
    public int ContractServiceId { get; set; }

    public double ContractServicePrices { get; set; }

    public int? ContractServiceSerRef { get; set; }

    public string? ContractServiceName { get; set; }

    public string? ContractServiceNotes { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string ContractServiceContractCode { get; set; } = null!;

    public string? OldServiceId { get; set; }

    public double? ContractServiceDiscount { get; set; }

    public bool ContractServiceFlag { get; set; }

    public string? ExternalCode { get; set; }

    public bool? IsPackage { get; set; }

    public virtual VendorContract ContractServiceContractCodeNavigation { get; set; } = null!;

    public virtual StandardService? ContractServiceSerRefNavigation { get; set; }
}
