using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class InvDetail
{
    public long Id { get; set; }

    public long? InvId { get; set; }

    public int? SrvId { get; set; }

    public double? OurPrice { get; set; }

    public double Cprice { get; set; }

    public double? Qty { get; set; }

    public string? MedFlag { get; set; }

    public string? SelectFlag { get; set; }

    public double SrvDis { get; set; }

    public string? DisReason { get; set; }

    public virtual BatchDetail? Inv { get; set; }
}
