using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Bill
{
    public int CustomerId { get; set; }

    public string ContractId { get; set; } = null!;

    public string? MemberId { get; set; }

    public int BillId { get; set; }

    public DateTime BillCreatedDate { get; set; }

    public string BillStatus { get; set; } = null!;

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime BillPeroidFrom { get; set; }

    public DateTime BillPeroidTo { get; set; }

    public int CostCentre { get; set; }

    public string? CustomerInstallmentId { get; set; }

    public DateOnly BillDueDate { get; set; }

    public string BillType { get; set; } = null!;

    public bool Printed { get; set; }

    public int? ExternalCode { get; set; }

    public string? Notes { get; set; }

    public decimal? AccBillId { get; set; }

    public int? RefId { get; set; }

    public int? ActionType { get; set; }

    public string? TransactionType { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual PaymentType BillTypeNavigation { get; set; } = null!;

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Member? Member { get; set; }
}
