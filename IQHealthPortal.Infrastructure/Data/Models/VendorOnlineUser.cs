using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorOnlineUser
{
    public long OnlineUserId { get; set; }

    public string? OnlineUserUserName { get; set; }

    public string? OnlineUserPassword { get; set; }

    public string? OnlineUserFirstName { get; set; }

    public string? OnlineUserLastName { get; set; }

    public string? OnlineUserStatus { get; set; }

    public DateTime? OnlineUserCreationDate { get; set; }

    public string? OnlineUserEmail { get; set; }

    public string? OnlineUserMobile { get; set; }

    public string? OnlineUserLang { get; set; }

    public string? OnlineUserTheme { get; set; }

    public string? OnlineUserAddress { get; set; }

    public long OnlineUserOffice { get; set; }

    public DateOnly? OnlineUserJoiningDate { get; set; }

    public string? OnlineUserProfilePicPath { get; set; }

    public int? OnlineUserRoleId { get; set; }

    public string OnlineUserVendor { get; set; } = null!;

    public string? OnlineUserVType { get; set; }

    public virtual VendorGeneral OnlineUserVendorNavigation { get; set; } = null!;
}
