using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class PrivilegeRequest
{
    public int Id { get; set; }

    public string UserRequestedBy { get; set; } = null!;

    public string UserRequestedFor { get; set; } = null!;

    public int Status { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string Note { get; set; } = null!;

    public int PageId { get; set; }

    public virtual StatusProcedure StatusNavigation { get; set; } = null!;

    public virtual AspNetUser UserRequestedByNavigation { get; set; } = null!;

    public virtual AspNetUser UserRequestedForNavigation { get; set; } = null!;
}
