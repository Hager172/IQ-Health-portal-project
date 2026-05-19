using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class NewsLog
{
    public int Id { get; set; }

    public int? Actionid { get; set; }

    public int? Newsid { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual Action? Action { get; set; }

    public virtual UpdatedNews? News { get; set; }
}
