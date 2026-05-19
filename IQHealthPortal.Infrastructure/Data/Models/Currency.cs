using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public string FullNameEn { get; set; } = null!;

    public string FullNameAr { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public virtual ICollection<CurrencyExchangable> CurrencyExchangables { get; set; } = new List<CurrencyExchangable>();
}
