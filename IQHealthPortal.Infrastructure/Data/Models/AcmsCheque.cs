using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AcmsCheque
{
    public int Id { get; set; }

    public int BankId { get; set; }

    public string? PayTo { get; set; }

    public double? Price { get; set; }

    public string? Signature { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public bool HasSlashes { get; set; }

    public virtual Bank Bank { get; set; } = null!;
}
