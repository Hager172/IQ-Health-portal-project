using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TpaMapMeditem
{
    public int Insurer { get; set; }

    public int Item { get; set; }

    public string? Name { get; set; }

    public int? DefaultCat { get; set; }

    public virtual ICollection<TpaMappedMeditem> TpaMappedMeditems { get; set; } = new List<TpaMappedMeditem>();
}
