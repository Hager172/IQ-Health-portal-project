using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsWarehouse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int Type { get; set; }

    public string? Address { get; set; }

    public string? Manger { get; set; }

    public string? Tel { get; set; }

    public virtual ICollection<ClaimFormLot> ClaimFormLots { get; set; } = new List<ClaimFormLot>();

    public virtual ICollection<UserWarehouse> UserWarehouses { get; set; } = new List<UserWarehouse>();
}
