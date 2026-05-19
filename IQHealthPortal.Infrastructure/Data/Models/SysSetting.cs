using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SysSetting
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ValSrt { get; set; }

    public int? ValInt { get; set; }

    public string? Description { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }
}
