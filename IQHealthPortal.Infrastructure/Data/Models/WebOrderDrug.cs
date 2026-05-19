using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebOrderDrug
{
    public long DrugId { get; set; }

    public long? PatientId { get; set; }

    public string? DrugName { get; set; }

    public string? DrugConcentration { get; set; }

    public string? PackagesCount { get; set; }

    public string? Comments { get; set; }

    public long OrderId { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? Attachment { get; set; }

    public virtual WebOrder Order { get; set; } = null!;
}
