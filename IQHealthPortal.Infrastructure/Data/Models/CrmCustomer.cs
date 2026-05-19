using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmCustomer
{
    public int TempId { get; set; }

    public int? OldCustomerId { get; set; }

    public string TempName { get; set; } = null!;

    public string? TaxFile { get; set; }

    public string? RegistertionNum { get; set; }

    public string Address { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public virtual ICollection<CrmCustomerContact> CrmCustomerContacts { get; set; } = new List<CrmCustomerContact>();

    public virtual ICollection<CrmCustomerContract> CrmCustomerContracts { get; set; } = new List<CrmCustomerContract>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual Customer? OldCustomer { get; set; }
}
