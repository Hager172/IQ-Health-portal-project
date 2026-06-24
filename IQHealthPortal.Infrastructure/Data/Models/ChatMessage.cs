using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class ChatMessage
{
    public long Id { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? Message { get; set; }

    public DateTime? SentAt { get; set; }
}
