using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class GeneralVisit
{
    public int Id { get; set; }

    public DateTime VisitDate { get; set; }

    public string? VisitNote { get; set; }

    public string? TargetPerson { get; set; }

    public bool IsCalling { get; set; }

    public int? CustomerId { get; set; }

    public string? VendorId { get; set; }

    public string? MemberId { get; set; }

    public long? ApprovalId { get; set; }

    public int? CrmCustomerId { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public bool HideGlassdoor { get; set; }

    public int VisitStatus { get; set; }

    public bool IsDeleted { get; set; }

    public bool? LastCrmVisit { get; set; }

    public int? CrmVisitStatus { get; set; }

    public virtual CrmCustomer? CrmCustomer { get; set; }

    public virtual StatusProcedure? CrmVisitStatusNavigation { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<GeneralVisitsUser> GeneralVisitsUsers { get; set; } = new List<GeneralVisitsUser>();

    public virtual Member? Member { get; set; }

    public virtual VendorGeneral? Vendor { get; set; }

    public virtual Status VisitStatusNavigation { get; set; } = null!;
}
