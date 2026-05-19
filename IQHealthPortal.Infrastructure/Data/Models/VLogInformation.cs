using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VLogInformation
{
    public string? UserName { get; set; }

    public DateTime? Date { get; set; }

    public string? Ip { get; set; }

    public string ActionName { get; set; } = null!;

    public string? Note { get; set; }

    public string Event { get; set; } = null!;

    public string? Description { get; set; }
}
