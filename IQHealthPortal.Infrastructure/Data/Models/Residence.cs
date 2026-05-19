using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Residence
{
    public string ResidenceId { get; set; } = null!;

    public string ResidenceName { get; set; } = null!;

    public virtual ICollection<ContractPlan> ContractPlans { get; set; } = new List<ContractPlan>();

    public virtual ICollection<CrmContractPlan> CrmContractPlans { get; set; } = new List<CrmContractPlan>();
}
