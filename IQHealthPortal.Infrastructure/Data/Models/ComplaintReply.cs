using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ComplaintReply
{
    public int Id { get; set; }

    public int? CustomerComplaintId { get; set; }

    public string? MemberComplaintId { get; set; }

    public string Note { get; set; } = null!;

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual CustomerComplaint? CustomerComplaint { get; set; }

    public virtual MembersComplaint? MemberComplaint { get; set; }
}
