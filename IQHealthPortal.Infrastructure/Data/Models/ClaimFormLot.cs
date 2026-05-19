using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ClaimFormLot
{
    public int Id { get; set; }

    public long StartSerial { get; set; }

    public long EndSerial { get; set; }

    public int ContentQty { get; set; }

    public DateTime EnteryDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool IsLocked { get; set; }

    public int WerehouseId { get; set; }

    public virtual ICollection<LotForm> LotForms { get; set; } = new List<LotForm>();

    public virtual AcmsWarehouse Werehouse { get; set; } = null!;
}
