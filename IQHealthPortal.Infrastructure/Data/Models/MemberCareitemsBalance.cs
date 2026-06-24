using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberCareitemsBalance
{
    public string MemberId { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public int MedItem { get; set; }

    public decimal? MedItemLimit { get; set; }

    public decimal? ClaimsBalance { get; set; }

    public decimal? ApprovalsBalance { get; set; }

    public string? Notes { get; set; }

    public int? CiCount { get; set; }
}
