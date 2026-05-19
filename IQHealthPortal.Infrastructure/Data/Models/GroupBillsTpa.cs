using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class GroupBillsTpa
{
    public int GroubId { get; set; }

    public decimal BillId { get; set; }

    public string? Notes { get; set; }
}
