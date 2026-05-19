using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class GeneralVisitsUser
{
    public int Id { get; set; }

    public int? GeneralVisitId { get; set; }

    public string? UserId { get; set; }

    public virtual GeneralVisit? GeneralVisit { get; set; }

    public virtual AspNetUser? User { get; set; }
}
