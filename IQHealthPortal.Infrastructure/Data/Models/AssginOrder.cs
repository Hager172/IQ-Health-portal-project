using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AssginOrder
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string UserId { get; set; } = null!;

    public int Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public virtual ICollection<AssginOrderLog> AssginOrderLogs { get; set; } = new List<AssginOrderLog>();

    public virtual ReceptionOrder Order { get; set; } = null!;

    public virtual Status StatusNavigation { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
