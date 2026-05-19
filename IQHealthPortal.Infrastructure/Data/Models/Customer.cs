using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int CustomerArea { get; set; }

    public int? CustomerParent { get; set; }

    public DateTime? CustomerCreationDate { get; set; }

    public bool CareCard { get; set; }

    public bool DirectChronic { get; set; }

    public string CustomerTele { get; set; } = null!;

    public string? CustomerTele2 { get; set; }

    public string? CustomerTele3 { get; set; }

    public string? CustomerAddress { get; set; }

    public string? CustomerContactPerson { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string CustomerWebsite { get; set; } = null!;

    public string CustomerMobile { get; set; } = null!;

    public string? CustomerFax { get; set; }

    public string? CustomerServiceHotline { get; set; }

    public string? CustomerServiceHotline2 { get; set; }

    public string? CustomerServiceVipHotline { get; set; }

    public string? CustomerServiceEmail { get; set; }

    public string? CustomerMedicinesService { get; set; }

    public string? CustomerMedicinesService2 { get; set; }

    public string? CustomerAccountNum { get; set; }

    public string? CustomerRecordNumber { get; set; }

    public string? CustomerTaxFile { get; set; }

    public string? CustomerTaxCard { get; set; }

    public int? CustomerCommission { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public string CustomerStatus { get; set; } = null!;

    public int? CustomerClientId { get; set; }

    public bool IsInsurer { get; set; }

    public string? WhatsappNumber { get; set; }

    public int? CompanyActivity { get; set; }

    public virtual ICollection<AcmsOtp> AcmsOtps { get; set; } = new List<AcmsOtp>();

    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<BlueCode> BlueCodes { get; set; } = new List<BlueCode>();

    public virtual ICollection<CardSettingsBranch> CardSettingsBranchCustomerIdBranchNavigations { get; set; } = new List<CardSettingsBranch>();

    public virtual ICollection<CardSettingsBranch> CardSettingsBranchCustomerIdParentNavigations { get; set; } = new List<CardSettingsBranch>();

    public virtual ICollection<ContractActivity> ContractActivityCustomers { get; set; } = new List<ContractActivity>();

    public virtual ICollection<ContractActivity> ContractActivityInsurerNavigations { get; set; } = new List<ContractActivity>();

    public virtual ICollection<CrmContractContractType> CrmContractContractTypes { get; set; } = new List<CrmContractContractType>();

    public virtual ICollection<CrmCustomer> CrmCustomers { get; set; } = new List<CrmCustomer>();

    public virtual ICollection<CurrencyExchangable> CurrencyExchangables { get; set; } = new List<CurrencyExchangable>();

    public virtual ICollection<CustomerArchive> CustomerArchives { get; set; } = new List<CustomerArchive>();

    public virtual Area CustomerAreaNavigation { get; set; } = null!;

    public virtual ICollection<CustomerAuthorizationRequest> CustomerAuthorizationRequests { get; set; } = new List<CustomerAuthorizationRequest>();

    public virtual ICollection<CustomerBillTpa> CustomerBillTpas { get; set; } = new List<CustomerBillTpa>();

    public virtual Client? CustomerClient { get; set; }

    public virtual ICollection<CustomerComplaint> CustomerComplaints { get; set; } = new List<CustomerComplaint>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerContract> CustomerContractCustomerContractCustomers { get; set; } = new List<CustomerContract>();

    public virtual ICollection<CustomerContract> CustomerContractCustomerContractInsurerNavigations { get; set; } = new List<CustomerContract>();

    public virtual Customer? CustomerParentNavigation { get; set; }

    public virtual StateRef CustomerStatusNavigation { get; set; } = null!;

    public virtual ICollection<CustomerVendorException> CustomerVendorExceptions { get; set; } = new List<CustomerVendorException>();

    public virtual ICollection<CustomersVisit> CustomersVisits { get; set; } = new List<CustomersVisit>();

    public virtual ICollection<DisRefund> DisRefunds { get; set; } = new List<DisRefund>();

    public virtual ICollection<GeneralVisit> GeneralVisits { get; set; } = new List<GeneralVisit>();

    public virtual ICollection<GroupsLog> GroupsLogs { get; set; } = new List<GroupsLog>();

    public virtual ICollection<InsuranceCategoryCode> InsuranceCategoryCodes { get; set; } = new List<InsuranceCategoryCode>();

    public virtual ICollection<InsurerVendorMap> InsurerVendorMaps { get; set; } = new List<InsurerVendorMap>();

    public virtual ICollection<Customer> InverseCustomerParentNavigation { get; set; } = new List<Customer>();

    public virtual MashCareCustomer? MashCareCustomerAcmsCutomer { get; set; }

    public virtual ICollection<MashCareCustomer> MashCareCustomerMashCareCustomerNavigations { get; set; } = new List<MashCareCustomer>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public virtual ICollection<NotesClaimGroup> NotesClaimGroups { get; set; } = new List<NotesClaimGroup>();

    public virtual ICollection<NotesTpaGroup> NotesTpaGroups { get; set; } = new List<NotesTpaGroup>();

    public virtual ICollection<SchCustomerArchive> SchCustomerArchives { get; set; } = new List<SchCustomerArchive>();

    public virtual ICollection<TempMember> TempMembers { get; set; } = new List<TempMember>();

    public virtual ICollection<UserCustomer> UserCustomers { get; set; } = new List<UserCustomer>();

    public virtual ICollection<VendorLog> VendorLogs { get; set; } = new List<VendorLog>();

    public virtual ICollection<WebCustomerRequest> WebCustomerRequests { get; set; } = new List<WebCustomerRequest>();
}
