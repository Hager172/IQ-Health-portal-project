using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ServiceReviewResponse
{
    public int Id { get; set; }

    public long? RatingId { get; set; }

    public string? FeedbackStatus { get; set; }

    public string? ReviewStatus { get; set; }

    public string? Note { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual ApprovalRating? Rating { get; set; }

    public virtual ICollection<AcmsOption> Options { get; set; } = new List<AcmsOption>();
}
