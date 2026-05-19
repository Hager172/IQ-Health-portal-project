using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientWebsite { get; set; }

    public string? ClientEmail { get; set; }

    public string? ClientTele { get; set; }

    public string? ClientMapUrl { get; set; }

    public int ClientRegionCode { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketsReply> TicketsReplies { get; set; } = new List<TicketsReply>();

    public virtual ICollection<VendorGeneral> VendorGenerals { get; set; } = new List<VendorGeneral>();
}
