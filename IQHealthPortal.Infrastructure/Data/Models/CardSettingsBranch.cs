using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CardSettingsBranch
{
    public int Id { get; set; }

    public string ContractId { get; set; } = null!;

    public int CustomerIdParent { get; set; }

    public int CustomerIdBranch { get; set; }

    public string? Front { get; set; }

    public string? FrontVip { get; set; }

    public string? Back { get; set; }

    public string? BackVip { get; set; }

    public bool NewCard { get; set; }

    public int CustomerName { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual CustomerContract Contract { get; set; } = null!;

    public virtual Customer CustomerIdBranchNavigation { get; set; } = null!;

    public virtual Customer CustomerIdParentNavigation { get; set; } = null!;
}
