using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TempMember
{
    public int Id { get; set; }

    public string? MemberId { get; set; }

    public int? CustomerId { get; set; }

    public string? MemberNationalId { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Member? Member { get; set; }
}
