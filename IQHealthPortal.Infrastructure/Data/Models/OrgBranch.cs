using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OrgBranch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int? OrgId { get; set; }

    public string Lang { get; set; } = null!;

    public string Lat { get; set; } = null!;

    public virtual OrganizationSetting? Org { get; set; }

    public virtual ICollection<UserDepartment> UserDepartments { get; set; } = new List<UserDepartment>();
}
