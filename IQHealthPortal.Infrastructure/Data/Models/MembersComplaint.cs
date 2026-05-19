using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class MembersComplaint
{
    public string Id { get; set; } = null!;

    public string? MemberId { get; set; }

    public int Department { get; set; }

    public string Complaint { get; set; } = null!;

    public string? Respond { get; set; }

    public bool Closed { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? VendorId { get; set; }

    public int? Type { get; set; }

    public long? ApprovalId { get; set; }

    public int? OptionId { get; set; }

    public string? InOutType { get; set; }

    public string? RequestSource { get; set; }

    public int? CustomerId { get; set; }

    public int? ComplaintType { get; set; }

    public int? Stauts { get; set; }

    public virtual Approval? Approval { get; set; }

    public virtual ComplanitType? ComplaintTypeNavigation { get; set; }

    public virtual ICollection<CrmLog> CrmLogs { get; set; } = new List<CrmLog>();

    public virtual Department DepartmentNavigation { get; set; } = null!;

    public virtual Member? Member { get; set; }

    public virtual AcmsOption? Option { get; set; }

    public virtual StatusProcedure? StautsNavigation { get; set; }

    public virtual Action? TypeNavigation { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }
}
