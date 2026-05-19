using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserWarehouse
{
    public string UserId { get; set; } = null!;

    public int WarehouseId { get; set; }

    public bool? Import { get; set; }

    public bool? Export { get; set; }

    public bool? Show { get; set; }

    public virtual AspNetUser User { get; set; } = null!;

    public virtual AcmsWarehouse Warehouse { get; set; } = null!;
}
