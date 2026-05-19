using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorBranch
{
    public long VendorBranchSerial { get; set; }

    public string VendorId { get; set; } = null!;

    public string? VendorBranchName { get; set; }

    public int VendorBranchareaId { get; set; }

    public string? VendorBranchAddress { get; set; }

    public string? VendorBranchTele { get; set; }

    public string? VendorBranchTele2 { get; set; }

    public string VendorBranchStatus { get; set; } = null!;

    public DateTime? VendorBranchDate { get; set; }

    public string? VendorBranchMapUrl { get; set; }

    public decimal? VendorBranchLongitude { get; set; }

    public decimal? VendorBranchLatitude { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int HeadOffice { get; set; }

    public string? VendorEmail { get; set; }

    public string OldId { get; set; } = null!;

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual VendorGeneral Vendor { get; set; } = null!;

    public virtual Area VendorBrancharea { get; set; } = null!;

    public virtual ICollection<VendorRating> VendorRatings { get; set; } = new List<VendorRating>();

    public virtual ICollection<VendorShift> VendorShifts { get; set; } = new List<VendorShift>();

    public virtual ICollection<VendorStatusMonitor> VendorStatusMonitors { get; set; } = new List<VendorStatusMonitor>();
}
