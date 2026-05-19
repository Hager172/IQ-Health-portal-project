using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmContractClass
{
    public int Id { get; set; }

    public int? CrmContractId { get; set; }

    public string? Class { get; set; }

    public int? MembersCount { get; set; }

    public virtual CrmCustomerContract? CrmContract { get; set; }

    public virtual ICollection<CrmContractPlan> CrmContractPlans { get; set; } = new List<CrmContractPlan>();
}
