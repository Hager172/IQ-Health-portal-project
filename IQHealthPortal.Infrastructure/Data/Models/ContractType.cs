using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractType
{
    public int Id { get; set; }

    public string? NameEn { get; set; }

    public string NameAr { get; set; } = null!;

    public int? Parent { get; set; }

    public virtual ICollection<ContractType> InverseParentNavigation { get; set; } = new List<ContractType>();

    public virtual ContractType? ParentNavigation { get; set; }
}
