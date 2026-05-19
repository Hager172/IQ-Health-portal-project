using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VBlueCode
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime CustomerContractStartDate { get; set; }

    public DateTime CustomerContractEndDate { get; set; }

    public int? TotalPremium { get; set; }

    public double? TotalConsumption { get; set; }

    public string Email { get; set; } = null!;

    public int Frequency { get; set; }

    public double WarningValue { get; set; }

    public int Id { get; set; }

    public string CustomerContractId { get; set; } = null!;
}
