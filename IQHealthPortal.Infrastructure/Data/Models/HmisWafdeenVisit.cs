using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class HmisWafdeenVisit
{
    public int Id { get; set; }

    public int? VisitId { get; set; }

    public int? HmisVisitId { get; set; }

    public virtual WafdeenVisit? Visit { get; set; }
}
