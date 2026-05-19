using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmcontractsLog
{
    public int Id { get; set; }

    public int? ContractId { get; set; }

    public int? ActionId { get; set; }

    public string? UserId { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? Notes { get; set; }

    public virtual Action? Action { get; set; }

    public virtual CrmCustomerContract? Contract { get; set; }

    public virtual AspNetUser? User { get; set; }
}
