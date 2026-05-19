using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TpaMappedMeditem
{
    public string ContractCode { get; set; } = null!;

    public int MedItem { get; set; }

    public int? TpaMedItem { get; set; }

    public int? CustomerId { get; set; }

    public virtual TpaMapMeditem? TpaMapMeditem { get; set; }
}
