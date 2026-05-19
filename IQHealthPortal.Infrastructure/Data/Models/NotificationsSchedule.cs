using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class NotificationsSchedule
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Msg { get; set; }

    public DateOnly? Date { get; set; }

    public string? ImgUrl { get; set; }
}
