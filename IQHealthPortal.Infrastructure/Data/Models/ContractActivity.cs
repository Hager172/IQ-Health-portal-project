using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ContractActivity
{
    public string ContractCode { get; set; } = null!;

    public int Serial { get; set; }

    public int CustomerId { get; set; }

    public string ActivityId { get; set; } = null!;

    public int? Insurer { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public virtual ContractType1 Activity { get; set; } = null!;

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual Customer Customer { get; set; } = null!;

    public virtual CustomerContract CustomerContract { get; set; } = null!;

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual Customer InsurerNavigation { get; set; } = null!;
}
