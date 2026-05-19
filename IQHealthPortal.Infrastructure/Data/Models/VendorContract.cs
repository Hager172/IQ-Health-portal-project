using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorContract
{
    public string VendorContractId { get; set; } = null!;

    public string VendorContractVendorId { get; set; } = null!;

    public DateTime VendorContractStartDate { get; set; }

    public string? VendorContractName { get; set; }

    public DateTime VendorContractEndDate { get; set; }

    public double VendorContractLocalDiscount { get; set; }

    public string? VendorContractNotes { get; set; }

    public double? VendorContractAdministrativeDiscount { get; set; }

    public double? VendorContractImportedDiscount { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public int? PriceListDoc { get; set; }

    public bool? HasConsult { get; set; }

    public string? ConsultNote { get; set; }

    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    public virtual VendorArchieve? PriceListDocNavigation { get; set; }

    public virtual VendorGeneral VendorContractVendor { get; set; } = null!;

    public virtual ICollection<VendorExceptionContract> VendorExceptionContracts { get; set; } = new List<VendorExceptionContract>();
}
