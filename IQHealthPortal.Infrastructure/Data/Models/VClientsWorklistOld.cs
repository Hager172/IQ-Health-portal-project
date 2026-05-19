using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VClientsWorklistOld
{
    public decimal Code { get; set; }

    public string Member { get; set; } = null!;

    public string? Vendor { get; set; }

    public string? Pic { get; set; }

    public DateTime ApprovalDate { get; set; }

    public string ActStatus { get; set; } = null!;

    public string? ApprovalType { get; set; }

    public string Source { get; set; } = null!;

    public string? Url { get; set; }

    public string? Notes { get; set; }

    public string? ContractId { get; set; }

    public string? Agent { get; set; }
}
