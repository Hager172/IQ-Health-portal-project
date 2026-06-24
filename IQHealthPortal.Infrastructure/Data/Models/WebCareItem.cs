using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebCareItem
{
    public long ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNameAr { get; set; }

    public string? ItemNameFr { get; set; }

    public bool Enable { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<WebCustomerCareItem> WebCustomerCareItems { get; set; } = new List<WebCustomerCareItem>();

    public virtual ICollection<WebMemberItem> WebMemberItems { get; set; } = new List<WebMemberItem>();
}
