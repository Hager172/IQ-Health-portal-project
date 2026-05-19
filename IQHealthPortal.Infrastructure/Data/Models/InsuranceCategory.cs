using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InsuranceCategory
{
    public int InsuranceCode { get; set; }

    public string? InsuranceName { get; set; }

    public virtual ICollection<InsuranceCategoryCode> InsuranceCategoryCodes { get; set; } = new List<InsuranceCategoryCode>();
}
