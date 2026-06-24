using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class RequiredTask
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public virtual ICollection<ReceptionOrder> ReceptionOrders { get; set; } = new List<ReceptionOrder>();
}
