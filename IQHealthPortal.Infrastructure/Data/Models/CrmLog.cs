using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmLog
{
    public int Id { get; set; }

    public string? ComplainId { get; set; }

    public string? Complaint { get; set; }

    public string? Respond { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public virtual MembersComplaint? Complain { get; set; }
}
