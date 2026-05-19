using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class TicketLog
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public int ActionId { get; set; }

    public string Username { get; set; } = null!;

    public DateTime ActionDate { get; set; }

    public string? Notes { get; set; }

    public virtual Action Action { get; set; } = null!;
}
