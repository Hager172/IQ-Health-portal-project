using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineOneUnitForm
{
    public int Id { get; set; }

    public string? Form { get; set; }

    public int? Type { get; set; }
}
