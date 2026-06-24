using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ParallelApproval
{
    public long Id { get; set; }

    public long Approvalid1 { get; set; }

    public long Approvalid2 { get; set; }

    public virtual Approval Approvalid1Navigation { get; set; } = null!;

    public virtual Approval Approvalid2Navigation { get; set; } = null!;
}
