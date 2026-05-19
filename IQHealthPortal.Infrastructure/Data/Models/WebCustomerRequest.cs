using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebCustomerRequest
{
    public string MemberName { get; set; } = null!;

    public long Serial { get; set; }

    public string Type { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime BirthDate { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public double? CoverageLimit { get; set; }

    public string? ResposeBy { get; set; }

    public string? Currency { get; set; }

    public int Customer { get; set; }

    public string? MemberPhone { get; set; }

    public string NationalId { get; set; } = null!;

    public string? MemberId { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual Customer CustomerNavigation { get; set; } = null!;

    public virtual WebMembersRegistration? WebMembersRegistration { get; set; }

    public virtual ICollection<WebCommonDisease> Diseases { get; set; } = new List<WebCommonDisease>();
}
