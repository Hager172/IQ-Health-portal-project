using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebOrder
{
    public long OrderId { get; set; }

    public string? PatientName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? CoverageLimitApproved { get; set; }

    public string? Status { get; set; }

    public DateTime? Date { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<WebOrderDrug> WebOrderDrugs { get; set; } = new List<WebOrderDrug>();

    public virtual ICollection<WebOrderFile> WebOrderFiles { get; set; } = new List<WebOrderFile>();
}
