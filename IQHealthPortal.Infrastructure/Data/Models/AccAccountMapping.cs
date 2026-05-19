using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class AccAccountMapping
{
    public string AccountNumber { get; set; } = null!;

    public string LinkId { get; set; } = null!;

    public int Id { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }
}
