using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VMembersBillOldDb
{
    public decimal BillId { get; set; }

    public string? MemberId { get; set; }

    public string? Contract { get; set; }

    public string? Customer { get; set; }

    public decimal? PatientPrice { get; set; }

    public DateTime? Date { get; set; }

    public string? String3 { get; set; }
}
