using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberFamily
{
    public int FamilyId { get; set; }

    public string? FamilyName { get; set; }

    public string? FamilyNoId { get; set; }

    public DateTime? FamilyBirthday { get; set; }

    public string FamilyParent { get; set; } = null!;

    public string? FamilyGender { get; set; }

    public string? FamilyType { get; set; }

    public virtual Member FamilyParentNavigation { get; set; } = null!;
}
