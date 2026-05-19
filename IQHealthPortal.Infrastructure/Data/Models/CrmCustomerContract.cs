using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmCustomerContract
{
    public int TempContractId { get; set; }

    public int TempCustomer { get; set; }

    public DateTime TempStartDate { get; set; }

    public DateTime? TempEndDate { get; set; }

    public DateTime? ActualStart { get; set; }

    public DateTime? ActualEnd { get; set; }

    public int? BrokerId { get; set; }

    public int Status { get; set; }

    public string? ActualContractId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual CustomerContract? ActualContract { get; set; }

    public virtual Broker? Broker { get; set; }

    public virtual ICollection<CrmContractClass> CrmContractClasses { get; set; } = new List<CrmContractClass>();

    public virtual ICollection<CrmContractContractType> CrmContractContractTypes { get; set; } = new List<CrmContractContractType>();

    public virtual ICollection<CrmContractExcutor> CrmContractExcutors { get; set; } = new List<CrmContractExcutor>();

    public virtual ICollection<CrmContractPlan> CrmContractPlans { get; set; } = new List<CrmContractPlan>();

    public virtual ICollection<CrmContractPool> CrmContractPools { get; set; } = new List<CrmContractPool>();

    public virtual ICollection<CrmCustomerContractCategory> CrmCustomerContractCategories { get; set; } = new List<CrmCustomerContractCategory>();

    public virtual ICollection<CrmcontractsLog> CrmcontractsLogs { get; set; } = new List<CrmcontractsLog>();

    public virtual StatusProcedure StatusNavigation { get; set; } = null!;

    public virtual CrmCustomer TempCustomerNavigation { get; set; } = null!;
}
