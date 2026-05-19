using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Inquery
{
    public int ReqId { get; set; }

    public int? ReqSource { get; set; }

    public string? ReqMember { get; set; }

    public string? ReqProvider { get; set; }

    public int? ReqAddressId { get; set; }

    public DateTime? ReqDate { get; set; }

    public string? ReqStatus { get; set; }

    public int? ReqType { get; set; }

    public string? ReqNote { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? ReqCategory { get; set; }

    public string? ReqParent { get; set; }

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<MashPayment> MashPayments { get; set; } = new List<MashPayment>();

    public virtual MemberContact? ReqAddress { get; set; }

    public virtual VendorCategory? ReqCategoryNavigation { get; set; }

    public virtual Member? ReqMemberNavigation { get; set; }

    public virtual Member? ReqParentNavigation { get; set; }

    public virtual VendorGeneral? ReqProviderNavigation { get; set; }
}
