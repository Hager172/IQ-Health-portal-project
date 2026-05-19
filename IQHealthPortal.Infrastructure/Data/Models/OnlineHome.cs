using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineHome
{
    public int AreaId { get; set; }

    public string Header { get; set; } = null!;

    public string? Context { get; set; }

    public int Piriorty { get; set; }

    public DateTime? Date { get; set; }

    public bool? Visable { get; set; }
}
