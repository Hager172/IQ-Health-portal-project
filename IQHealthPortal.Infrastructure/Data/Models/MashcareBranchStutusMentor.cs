using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MashcareBranchStutusMentor
{
    public int Id { get; set; }

    public long BranchId { get; set; }

    public bool Status { get; set; }

    public DateTime Date { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public virtual VendorBranch Branch { get; set; } = null!;
}
