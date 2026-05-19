using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmContractContractType
{
    public int Id { get; set; }

    public int? CrmContractId { get; set; }

    public string? ContractTypeId { get; set; }

    public int? Insurer { get; set; }

    public double? ManagementFees { get; set; }

    public virtual ContractType1? ContractType { get; set; }

    public virtual CrmCustomerContract? CrmContract { get; set; }

    public virtual ICollection<CrmContractPlan> CrmContractPlans { get; set; } = new List<CrmContractPlan>();

    public virtual Customer? InsurerNavigation { get; set; }
}
