using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class StandardService
{
    public int StandServiceCode { get; set; }

    public string? StandServiceName { get; set; }

    public string? StandServiceAvailability { get; set; }

    public int? StandServiceParent { get; set; }

    public int? StandServiceVendorCategoryId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? StandServiceFlag { get; set; }

    public string? StandServiceNameAr { get; set; }

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    public virtual ICollection<StandardService> InverseStandServiceParentNavigation { get; set; } = new List<StandardService>();

    public virtual StandardService? StandServiceParentNavigation { get; set; }

    public virtual VendorCategory? StandServiceVendorCategory { get; set; }

    public virtual ICollection<VendorFixedService> VendorFixedServices { get; set; } = new List<VendorFixedService>();

    public virtual ICollection<PlanItem> PlanItems { get; set; } = new List<PlanItem>();
}
