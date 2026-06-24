using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserPlanPaymentBill
{
    public long Paymentid { get; set; }

    public long Billid { get; set; }
}
