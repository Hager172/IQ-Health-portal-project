using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VSearchAllMember
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string MemberStatues { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CustomerStatus { get; set; } = null!;

    public DateTime? CustomerContractStartDate { get; set; }

    public DateTime? CustomerContractEndDate { get; set; }

    public string? CustomerContractId { get; set; }

    public string? PlanCode { get; set; }

    public string? MStatus { get; set; }

    public int MainCustomerId { get; set; }
}
