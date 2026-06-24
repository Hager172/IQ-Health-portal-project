using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebCustomerCareItem
{
    public string Customer { get; set; } = null!;

    public long Item { get; set; }

    public virtual WebCareItem ItemNavigation { get; set; } = null!;
}
