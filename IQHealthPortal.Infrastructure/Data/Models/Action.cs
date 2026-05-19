using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Action
{
    public int ActionId { get; set; }

    public string ActionName { get; set; } = null!;

    public virtual ICollection<ApprovalsLogOnline> ApprovalsLogOnlines { get; set; } = new List<ApprovalsLogOnline>();

    public virtual ICollection<ApprovalsLog> ApprovalsLogs { get; set; } = new List<ApprovalsLog>();

    public virtual ICollection<BatchLog> BatchLogs { get; set; } = new List<BatchLog>();

    public virtual ICollection<BillsLog> BillsLogs { get; set; } = new List<BillsLog>();

    public virtual ICollection<ClaimLog> ClaimLogs { get; set; } = new List<ClaimLog>();

    public virtual ICollection<ContractLog> ContractLogs { get; set; } = new List<ContractLog>();

    public virtual ICollection<CrmcontractsLog> CrmcontractsLogs { get; set; } = new List<CrmcontractsLog>();

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual ICollection<MembersLog> MembersLogs { get; set; } = new List<MembersLog>();

    public virtual ICollection<NewsLog> NewsLogs { get; set; } = new List<NewsLog>();

    public virtual ICollection<PaymentsLog> PaymentsLogs { get; set; } = new List<PaymentsLog>();

    public virtual ICollection<SchApprovalsLog> SchApprovalsLogs { get; set; } = new List<SchApprovalsLog>();

    public virtual ICollection<TicketLog> TicketLogs { get; set; } = new List<TicketLog>();

    public virtual ICollection<VendorLog> VendorLogs { get; set; } = new List<VendorLog>();

    public virtual ICollection<VendorStatusMonitor> VendorStatusMonitors { get; set; } = new List<VendorStatusMonitor>();
}
