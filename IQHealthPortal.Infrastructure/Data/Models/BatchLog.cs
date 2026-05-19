using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class BatchLog
{
    public int Id { get; set; }

    public long? InvId { get; set; }

    public decimal? BatchId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? Action { get; set; }

    public string? Note { get; set; }

    public string? LastUpdateFrom { get; set; }

    public bool? InternalTpaRevision { get; set; }

    public int? Statusid { get; set; }

    public virtual Action? ActionNavigation { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual StatusProcedure? Status { get; set; }
}
