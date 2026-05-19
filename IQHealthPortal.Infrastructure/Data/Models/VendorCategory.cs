using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorCategory
{
    public int VendorCategoryId { get; set; }

    public string VendorCategoryName { get; set; } = null!;

    public int? VendorCategoryParent { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public string VendorCategoryAlphaCode { get; set; } = null!;

    public int VendorCategoryPolicyTax { get; set; }

    public int? OldId { get; set; }

    public int? SortIndex { get; set; }

    public virtual ICollection<CrmItemCopayment> CrmItemCopayments { get; set; } = new List<CrmItemCopayment>();

    public virtual ICollection<Inquery> Inqueries { get; set; } = new List<Inquery>();

    public virtual ICollection<InsuranceCategoryCode> InsuranceCategoryCodes { get; set; } = new List<InsuranceCategoryCode>();

    public virtual ICollection<VendorCategory> InverseVendorCategoryParentNavigation { get; set; } = new List<VendorCategory>();

    public virtual ICollection<ItemCopayment> ItemCopayments { get; set; } = new List<ItemCopayment>();

    public virtual ICollection<MemberArchiveDoc> MemberArchiveDocs { get; set; } = new List<MemberArchiveDoc>();

    public virtual ICollection<Neqabat> Neqabats { get; set; } = new List<Neqabat>();

    public virtual ICollection<StandardService> StandardServices { get; set; } = new List<StandardService>();

    public virtual VendorCategory? VendorCategoryParentNavigation { get; set; }

    public virtual ICollection<VendorGeneralTemp> VendorGeneralTemps { get; set; } = new List<VendorGeneralTemp>();

    public virtual ICollection<VendorGeneral> VendorGenerals { get; set; } = new List<VendorGeneral>();

    public virtual ICollection<VendorsCopayment> VendorsCopayments { get; set; } = new List<VendorsCopayment>();

    public virtual ICollection<VendorGeneral> Vendors { get; set; } = new List<VendorGeneral>();
}
