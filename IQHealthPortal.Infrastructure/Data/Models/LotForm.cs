using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class LotForm
{
    public int ClaimFormLotsId { get; set; }

    public long StartSerial { get; set; }

    public int? Code { get; set; }

    public virtual ClaimFormLot ClaimFormLots { get; set; } = null!;

    public virtual ClaimLotsFormsCode? CodeNavigation { get; set; }
}
