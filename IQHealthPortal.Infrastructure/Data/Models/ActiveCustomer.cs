using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ActiveCustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Telephones { get; set; }

    public int? MembersCount { get; set; }

    public string CustomerContractId { get; set; } = null!;

    public DateTime CustomerContractStartDate { get; set; }

    public DateTime CustomerContractEndDate { get; set; }

    public string? Hotlines { get; set; }

    public string? MedicineServices { get; set; }

    public string? CustomerAccountNum { get; set; }

    public string? CustomerRecordNumber { get; set; }

    public string? CustomerTaxFile { get; set; }

    public string? CustomerTaxCard { get; set; }

    public int? CustomerCommission { get; set; }

    public string? CustomerAddress { get; set; }

    public string AreaNameAr { get; set; } = null!;

    public string GovName { get; set; } = null!;

    public string? ContractTypeNameEn { get; set; }
}
