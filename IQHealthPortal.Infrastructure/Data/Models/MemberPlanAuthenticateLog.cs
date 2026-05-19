using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MemberPlanAuthenticateLog
{
    public int Id { get; set; }

    public int AuthenticationId { get; set; }

    public string MemberCode { get; set; } = null!;

    public string MemberPlan { get; set; } = null!;

    public DateTime Time { get; set; }

    public string Machine { get; set; } = null!;

    public virtual McAuthenticate Authentication { get; set; } = null!;

    public virtual Member MemberCodeNavigation { get; set; } = null!;

    public virtual ContractPlan MemberPlanNavigation { get; set; } = null!;
}
