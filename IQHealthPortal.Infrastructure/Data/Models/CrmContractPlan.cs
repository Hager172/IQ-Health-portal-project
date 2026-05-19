using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmContractPlan
{
    public int Id { get; set; }

    public string? ContractPlanId { get; set; }

    public int CrmContractId { get; set; }

    public int? ClassId { get; set; }

    public int? ContractTypeId { get; set; }

    public string? ContractPlanNotes { get; set; }

    public bool? ContractPlanReimb { get; set; }

    public double? ClassCeiling { get; set; }

    public bool? IsDirect { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string? ResidenceId { get; set; }

    public string? ExternalCode { get; set; }

    public int? ResidencePercent { get; set; }

    public string? CeilingLevel { get; set; }

    public string? MedicalNetworkClass { get; set; }

    public virtual CrmContractClass? Class { get; set; }

    public virtual CrmContractContractType? ContractType { get; set; }

    public virtual CrmCustomerContract CrmContract { get; set; } = null!;

    public virtual ICollection<CrmPlanItem> CrmPlanItems { get; set; } = new List<CrmPlanItem>();

    public virtual Residence? Residence { get; set; }
}
