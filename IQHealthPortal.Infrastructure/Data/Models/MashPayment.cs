using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MashPayment
{
    public int PayId { get; set; }

    public string PayCode { get; set; } = null!;

    public int ReqId { get; set; }

    public long? ApprovalId { get; set; }

    public int PayType { get; set; }

    public string PayStatus { get; set; } = null!;

    public DateTime PayDate { get; set; }

    public double PayValue { get; set; }

    public string? PayLink { get; set; }

    public DateTime ExpireDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public virtual Approval? Approval { get; set; }

    public virtual Approval? ApprovalNavigation { get; set; }

    public virtual PaymentChannel PayTypeNavigation { get; set; } = null!;

    public virtual Inquery Req { get; set; } = null!;
}
