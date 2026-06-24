using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Bank
{
    public int Id { get; set; }

    public string BankName { get; set; } = null!;

    public string? BankNameAr { get; set; }

    public string? BankShortName { get; set; }

    public string? BankPathName { get; set; }

    public virtual ICollection<AcmsCheque> AcmsCheques { get; set; } = new List<AcmsCheque>();
}
