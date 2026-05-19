using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserDepartment
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int DeptId { get; set; }

    public int? ParentId { get; set; }

    public int BranchId { get; set; }

    public string? UserFullName { get; set; }

    public virtual Department Dept { get; set; } = null!;

    public virtual ICollection<UserDepartment> InverseParent { get; set; } = new List<UserDepartment>();

    public virtual UserDepartment? Parent { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
