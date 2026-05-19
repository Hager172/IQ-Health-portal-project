using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CareItem
{
    public int CareItemCode { get; set; }

    public string CareItemName { get; set; } = null!;

    public bool IsMandatory { get; set; }

    public virtual ICollection<ApprovalService> ApprovalServices { get; set; } = new List<ApprovalService>();

    public virtual ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();

    public virtual ICollection<ChronicLookupTable> ChronicLookupTables { get; set; } = new List<ChronicLookupTable>();

    public virtual ICollection<CrmPlanItem> CrmPlanItems { get; set; } = new List<CrmPlanItem>();

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ICollection<PlanItem> PlanItems { get; set; } = new List<PlanItem>();

    public virtual ICollection<SchApprovalService> SchApprovalServices { get; set; } = new List<SchApprovalService>();

    public virtual ICollection<OnlineItemCategory> Cids { get; set; } = new List<OnlineItemCategory>();
}
