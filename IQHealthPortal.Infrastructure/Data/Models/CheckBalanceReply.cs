using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CheckBalanceReply
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateAt { get; set; }

    public int? CurrentMeditem { get; set; }

    public int? UpdatedMeditem { get; set; }

    public bool? Accepted { get; set; }

    public string? RequiredBy { get; set; }

    public DateTime? RequiredAt { get; set; }

    public bool? HasAttach { get; set; }

    public string? Notes { get; set; }

    public long InvId { get; set; }

    public virtual CareItem? CurrentMeditemNavigation { get; set; }

    public virtual CareItem? UpdatedMeditemNavigation { get; set; }
}
