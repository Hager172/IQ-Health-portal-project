using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UpdatedNewsAspNetUser
{
    public int Id { get; set; }

    public int NewsId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual UpdatedNews News { get; set; } = null!;
}
