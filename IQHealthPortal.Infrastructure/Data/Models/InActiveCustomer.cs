using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InActiveCustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int CustomerArea { get; set; }

    public int? CustomerParent { get; set; }

    public DateTime? CustomerCreationDate { get; set; }

    public bool CareCard { get; set; }

    public bool DirectChronic { get; set; }

    public string CustomerTele { get; set; } = null!;

    public string? CustomerTele2 { get; set; }

    public string? CustomerTele3 { get; set; }

    public string? CustomerAddress { get; set; }

    public string? CustomerContactPerson { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string CustomerWebsite { get; set; } = null!;

    public string CustomerMobile { get; set; } = null!;

    public string? CustomerFax { get; set; }

    public string? CustomerServiceHotline { get; set; }

    public string? CustomerServiceHotline2 { get; set; }

    public string? CustomerServiceVipHotline { get; set; }

    public string? CustomerServiceEmail { get; set; }

    public string? CustomerMedicinesService { get; set; }

    public string? CustomerMedicinesService2 { get; set; }

    public string? CustomerAccountNum { get; set; }

    public string? CustomerRecordNumber { get; set; }

    public string? CustomerTaxFile { get; set; }

    public string? CustomerTaxCard { get; set; }

    public int? CustomerCommission { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string CustomerStatus { get; set; } = null!;

    public int? CustomerClientId { get; set; }

    public bool IsInsurer { get; set; }

    public string? WhatsappNumber { get; set; }

    public int? CompanyActivity { get; set; }

    public string? CustomerContractId { get; set; }

    public int? Members { get; set; }

    public DateTime? CustomerContractEndDate { get; set; }
}
