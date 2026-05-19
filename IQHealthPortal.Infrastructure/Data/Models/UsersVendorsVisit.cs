using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class UsersVendorsVisit
{
    public int Id { get; set; }

    public int? VendorVisitId { get; set; }

    public string? UserId { get; set; }

    public virtual AspNetUser? User { get; set; }

    public virtual VendorsVisit? VendorVisit { get; set; }
}
