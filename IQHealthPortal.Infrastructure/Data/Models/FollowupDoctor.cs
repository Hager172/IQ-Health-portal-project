using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class FollowupDoctor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsUser { get; set; }

    public virtual ICollection<ApprovalFollowUp> ApprovalFollowUps { get; set; } = new List<ApprovalFollowUp>();
}
