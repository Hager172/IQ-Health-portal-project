using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VitalSign
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? MeasurmentUnit { get; set; }

    public string? LogoIcon { get; set; }

    public virtual ICollection<VitalSignsMember> VitalSignsMembers { get; set; } = new List<VitalSignsMember>();
}
