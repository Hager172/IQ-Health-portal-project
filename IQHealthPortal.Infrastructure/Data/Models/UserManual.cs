using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserManual
{
    public int Id { get; set; }

    public int PageId { get; set; }

    public string? FilePath { get; set; }

    public string Description { get; set; } = null!;

    public string? ImagePath { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }
}
