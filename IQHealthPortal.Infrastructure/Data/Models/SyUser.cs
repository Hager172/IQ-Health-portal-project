using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class SyUser
{
    public int UserCode { get; set; }

    public string? StEmpid { get; set; }

    public string UserLogon { get; set; } = null!;

    public string? UserPwd { get; set; }

    public string? UserType { get; set; }

    public string? DrpName { get; set; }

    public string? GrpDesc { get; set; }

    public string? AccEnabled { get; set; }

    public string? PfcUserid { get; set; }

    public string? SignPicture { get; set; }

    public string? LinkUserCustomer { get; set; }

    public string? MacAddress { get; set; }

    public string? VersionNumber { get; set; }

    public DateTime? VersionInstallDate { get; set; }

    public string? IpAddress { get; set; }

    public string? PcName { get; set; }

    public string? NewPassword { get; set; }

    public string? OldPass { get; set; }

    public string? TempPass { get; set; }

    public string? Passwd { get; set; }
}
