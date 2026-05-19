using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class OnlineUser
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public short? Status { get; set; }

    public DateOnly? BirthOfDate { get; set; }

    public DateOnly? CreationDate { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Lang { get; set; }

    public string? Theme { get; set; }

    public string? CountryId { get; set; }

    public string? Address { get; set; }

    public string? Position { get; set; }

    public string? Office { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public decimal? Salary { get; set; }

    public long? ProfilePicDocumentId { get; set; }

    public int? RoleId { get; set; }

    public string? Vendor { get; set; }

    public string? VType { get; set; }

    public virtual ICollection<OnlineMessage> OnlineMessageFromUsers { get; set; } = new List<OnlineMessage>();

    public virtual ICollection<OnlineMessage> OnlineMessageToUsers { get; set; } = new List<OnlineMessage>();
}
