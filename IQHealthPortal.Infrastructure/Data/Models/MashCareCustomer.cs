using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MashCareCustomer
{
    public int AcmsCutomerId { get; set; }

    public int MashCareCustomerId { get; set; }

    public virtual Customer AcmsCutomer { get; set; } = null!;

    public virtual Customer MashCareCustomerNavigation { get; set; } = null!;
}
