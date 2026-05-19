using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UserFavoriteMenu
{
    public string UserId { get; set; } = null!;

    public int MenueId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
