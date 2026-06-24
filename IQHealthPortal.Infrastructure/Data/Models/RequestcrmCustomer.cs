using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class RequestcrmCustomer
{
    public int TempId { get; set; }

    public string TempName { get; set; } = null!;

    public string TaxFile { get; set; } = null!;

    public string RegistertionNum { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int BrokerId { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public DateTime DelegationDate { get; set; }

    public string? DelegationPath { get; set; }

    public string? MedicalNetwork { get; set; }

    public int? StatusId { get; set; }

    public string CustomerTele { get; set; } = null!;

    public virtual Broker Broker { get; set; } = null!;

    public virtual ICollection<RequestcrmClass> RequestcrmClasses { get; set; } = new List<RequestcrmClass>();

    public virtual ICollection<RequestcrmCustomerCategory> RequestcrmCustomerCategories { get; set; } = new List<RequestcrmCustomerCategory>();

    public virtual StatusProcedure? Status { get; set; }
}
