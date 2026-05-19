using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractLog
{
    public int Id { get; set; }

    public string ContractId { get; set; } = null!;

    public int Action { get; set; }

    public string Note { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual Action ActionNavigation { get; set; } = null!;
}
