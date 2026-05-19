using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CardSetting
{
    public string ContractId { get; set; } = null!;

    public bool ShowAge { get; set; }

    public bool ShowCompanyCode { get; set; }

    public bool ShowExternalCode { get; set; }

    public bool ShowJobTitle { get; set; }

    public bool ShowInsuranceCode { get; set; }

    public bool ShowStatement { get; set; }

    public int? CustomerName { get; set; }

    public string? Front { get; set; }

    public string? FrontVip { get; set; }

    public string? Back { get; set; }

    public string? BackVip { get; set; }

    public string? StaticBack { get; set; }

    public string? Notes { get; set; }

    public bool PrintClass { get; set; }

    public bool StaticBackground { get; set; }

    public bool NewCard { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public bool ShowWhatsappNumber { get; set; }

    public string? NameInCard { get; set; }
}
