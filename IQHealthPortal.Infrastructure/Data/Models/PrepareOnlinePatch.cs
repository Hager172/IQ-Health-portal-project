using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PrepareOnlinePatch
{
    public long Id { get; set; }

    public decimal Rcode { get; set; }

    public decimal ActId { get; set; }

    public int? Serial { get; set; }

    public string? Member { get; set; }

    public int? MedItem { get; set; }

    public string? UserName { get; set; }
}
