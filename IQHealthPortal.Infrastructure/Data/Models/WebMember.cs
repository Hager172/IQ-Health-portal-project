using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebMember
{
    public long MemberId { get; set; }

    public string? Name { get; set; }

    public DateTime? Birthdate { get; set; }

    public DateTime? EntryDate { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? StEmpId { get; set; }

    public string? Phone { get; set; }

    public string? CurrencyType { get; set; }

    public string? Customer { get; set; }
}
