using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Area
{
    public int AreaCode { get; set; }

    public int? AreaParent { get; set; }

    public string AreaNameAr { get; set; } = null!;

    public string? AreaNameEg { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual Area? AreaParentNavigation { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Area> InverseAreaParentNavigation { get; set; } = new List<Area>();

    public virtual ICollection<MemberContact> MemberContacts { get; set; } = new List<MemberContact>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public virtual ICollection<VendorBranch> VendorBranches { get; set; } = new List<VendorBranch>();

    public virtual ICollection<VendorBranchesTemp> VendorBranchesTemps { get; set; } = new List<VendorBranchesTemp>();

    public virtual ICollection<VendorGeneralTemp> VendorGeneralTemps { get; set; } = new List<VendorGeneralTemp>();

    public virtual ICollection<VendorGeneral> VendorGenerals { get; set; } = new List<VendorGeneral>();
}
