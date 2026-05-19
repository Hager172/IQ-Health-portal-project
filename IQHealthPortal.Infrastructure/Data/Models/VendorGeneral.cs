using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class VendorGeneral
{
    public string VendorId { get; set; } = null!;

    public string? VendorAddress { get; set; }

    public int VendorCategoryId { get; set; }

    public string? VendorFax { get; set; }

    public string VendorStatus { get; set; } = null!;

    public DateTime VendorCreationDate { get; set; }

    public string? VendorMapUrl { get; set; }

    public string? VendorName { get; set; }

    public int VendorClientId { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? VendorStatusDate { get; set; }

    public int? VendorArea { get; set; }

    public string? VendorTele { get; set; }

    public string? VendorTele1 { get; set; }

    public string? VendorTele2 { get; set; }

    public decimal? VendorLongitude { get; set; }

    public decimal? VendorLatitude { get; set; }

    public string? VendorContractExecutor { get; set; }

    public string? VendorTaxFile { get; set; }

    public string? VendorCommercialRecord { get; set; }

    public string? VendorTaxId { get; set; }

    public bool? VendorTax { get; set; }

    public int? VendorPayPeriod { get; set; }

    public string? VendorTaxArea { get; set; }

    public string? VendorCheckBeneficiary { get; set; }

    public string? VendorEmail { get; set; }

    public string OldId { get; set; } = null!;

    public bool? HasEta { get; set; }

    public DateOnly? EtaStart { get; set; }

    public bool? IsHosting { get; set; }

    public bool? IsCash { get; set; }

    public string? ParentId { get; set; }

    public virtual ICollection<AccVendorClosedYr> AccVendorClosedYrs { get; set; } = new List<AccVendorClosedYr>();

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<BatchDetail> BatchDetailCashVendorNavigations { get; set; } = new List<BatchDetail>();

    public virtual ICollection<BatchDetail> BatchDetailVendors { get; set; } = new List<BatchDetail>();

    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    public virtual ICollection<ClaimLotsFormsCode> ClaimLotsFormsCodes { get; set; } = new List<ClaimLotsFormsCode>();

    public virtual ICollection<Claim> Claims { get; set; } = new List<Claim>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<CrmItemCopayment> CrmItemCopayments { get; set; } = new List<CrmItemCopayment>();

    public virtual ICollection<CustomerComplaint> CustomerComplaints { get; set; } = new List<CustomerComplaint>();

    public virtual ICollection<CustomerVendorException> CustomerVendorExceptions { get; set; } = new List<CustomerVendorException>();

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual ICollection<Inquery> Inqueries { get; set; } = new List<Inquery>();

    public virtual ICollection<InsurerVendorMap> InsurerVendorMaps { get; set; } = new List<InsurerVendorMap>();

    public virtual ICollection<VendorGeneral> InverseParent { get; set; } = new List<VendorGeneral>();

    public virtual ICollection<ItemCopayment> ItemCopayments { get; set; } = new List<ItemCopayment>();

    public virtual ICollection<MembersComplaint> MembersComplaints { get; set; } = new List<MembersComplaint>();

    public virtual VendorGeneral? Parent { get; set; }

    public virtual Area? VendorAreaNavigation { get; set; }

    public virtual ICollection<VendorBranch> VendorBranches { get; set; } = new List<VendorBranch>();

    public virtual VendorCategory VendorCategory { get; set; } = null!;

    public virtual ICollection<VendorChanged> VendorChangedNewVendorNavigations { get; set; } = new List<VendorChanged>();

    public virtual ICollection<VendorChanged> VendorChangedOldVendorNavigations { get; set; } = new List<VendorChanged>();

    public virtual ICollection<VendorClaim> VendorClaims { get; set; } = new List<VendorClaim>();

    public virtual Client VendorClient { get; set; } = null!;

    public virtual ICollection<VendorContract> VendorContracts { get; set; } = new List<VendorContract>();

    public virtual ICollection<VendorDoctor> VendorDoctors { get; set; } = new List<VendorDoctor>();

    public virtual ICollection<VendorExceptionContract> VendorExceptionContracts { get; set; } = new List<VendorExceptionContract>();

    public virtual VendorMedCare? VendorMedCare { get; set; }

    public virtual ICollection<VendorOnlineUser> VendorOnlineUsers { get; set; } = new List<VendorOnlineUser>();

    public virtual ICollection<VendorRating> VendorRatings { get; set; } = new List<VendorRating>();

    public virtual ICollection<VendorShift> VendorShifts { get; set; } = new List<VendorShift>();

    public virtual ICollection<VendorSpecialrole> VendorSpecialroles { get; set; } = new List<VendorSpecialrole>();

    public virtual ICollection<VendorStatusMonitor> VendorStatusMonitors { get; set; } = new List<VendorStatusMonitor>();

    public virtual ICollection<VendorsCopayment> VendorsCopayments { get; set; } = new List<VendorsCopayment>();

    public virtual ICollection<VendorsVisit> VendorsVisits { get; set; } = new List<VendorsVisit>();

    public virtual ICollection<WafdeenMembersSchedule> WafdeenMembersSchedules { get; set; } = new List<WafdeenMembersSchedule>();

    public virtual ICollection<WafdeenVisit> WafdeenVisits { get; set; } = new List<WafdeenVisit>();

    public virtual ICollection<WithContractedPrice> WithContractedPrices { get; set; } = new List<WithContractedPrice>();

    public virtual ICollection<VendorCategory> Categories { get; set; } = new List<VendorCategory>();

    public virtual ICollection<VendorClaimPool> Pools { get; set; } = new List<VendorClaimPool>();

    public virtual ICollection<AcmsSpecialization> Specializations { get; set; } = new List<AcmsSpecialization>();
}
