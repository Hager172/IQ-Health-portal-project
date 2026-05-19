using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccFinancialYr
{
    public short ClosedYear { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionBy { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string UserIp { get; set; } = null!;

    public string BrowserInfo { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string Status { get; set; } = null!;

    public string SecurityCode { get; set; } = null!;

    public int RefCode { get; set; }

    public virtual ICollection<AccVendorClosedYr> AccVendorClosedYrAccFinancialYrs { get; set; } = new List<AccVendorClosedYr>();

    public virtual ICollection<AccVendorClosedYr> AccVendorClosedYrRefs { get; set; } = new List<AccVendorClosedYr>();

    public virtual AspNetUser User { get; set; } = null!;
}
