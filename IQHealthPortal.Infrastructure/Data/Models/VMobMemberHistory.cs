using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMobMemberHistory
{
    public string MemberId { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? DocDate { get; set; }

    public DateTime? ADate { get; set; }

    public string? DocName { get; set; }

    public decimal? CatCode { get; set; }

    public string? Category { get; set; }
}
