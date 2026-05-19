using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerDatasheet
{
    public DateTime Date { get; set; }

    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? CustomerAddressCountry { get; set; }

    public string? CustomerAddressCity { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string? CompanyPosition { get; set; }

    public string? CompanyEmail { get; set; }

    public string TelephoneFax { get; set; } = null!;

    public string? Business { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }
}
