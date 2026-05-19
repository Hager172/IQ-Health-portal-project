using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ClaimLotsFormsCode
{
    public int Id { get; set; }

    public string VendorId { get; set; } = null!;

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? SendByMail { get; set; }

    public virtual ICollection<LotForm> LotForms { get; set; } = new List<LotForm>();

    public virtual VendorGeneral Vendor { get; set; } = null!;
}
