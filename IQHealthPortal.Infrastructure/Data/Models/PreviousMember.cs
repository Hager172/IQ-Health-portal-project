using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PreviousMember
{
    public int Id { get; set; }

    public string? MemberId1 { get; set; }

    public string? MemberId2 { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Member? MemberId1Navigation { get; set; }

    public virtual Member? MemberId2Navigation { get; set; }
}
