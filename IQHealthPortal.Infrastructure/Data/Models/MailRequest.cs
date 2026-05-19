using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MailRequest
{
    public long Id { get; set; }

    public string? MailFrom { get; set; }

    public string? MailSubj { get; set; }

    public string? MailBody { get; set; }

    public string? MailLink { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? MailTo { get; set; }

    public long? LinkedApproval { get; set; }
}
