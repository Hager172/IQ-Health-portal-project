using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class StoredProceduresList
{
    public int Id { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectType { get; set; }
}
