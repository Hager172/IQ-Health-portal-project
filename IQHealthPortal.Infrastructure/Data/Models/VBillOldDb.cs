using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VBillOldDb
{
    public decimal BillId { get; set; }

    public string BillCat { get; set; } = null!;

    public string SaEmpid { get; set; } = null!;

    public decimal? SaRcode { get; set; }

    public int SaSerial { get; set; }
}
