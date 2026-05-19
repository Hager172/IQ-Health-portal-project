using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UpdatedNews
{
    public int Id { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? FilePath { get; set; }

    public string? Image { get; set; }

    public string? Title { get; set; }

    public string? Note { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? IsActive { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual ICollection<NewsLog> NewsLogs { get; set; } = new List<NewsLog>();

    public virtual ICollection<UpdatedNewsAspNetUser> UpdatedNewsAspNetUsers { get; set; } = new List<UpdatedNewsAspNetUser>();

    public virtual ICollection<UpdatedNewsComment> UpdatedNewsComments { get; set; } = new List<UpdatedNewsComment>();
}
