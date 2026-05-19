using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UpdatedNewsComment
{
    public int Id { get; set; }

    public int NewId { get; set; }

    public bool? Liked { get; set; }

    public string? Comment { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string UserId { get; set; } = null!;

    public virtual UpdatedNews New { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
