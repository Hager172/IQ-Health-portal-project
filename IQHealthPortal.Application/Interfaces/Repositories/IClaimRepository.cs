using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.DTOs.itemsDtos;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IClaimRepository
    {
        Task<OnlineServiceItemDto?> GetPharmaItemAsync(int? itemId);

        Task<(float Coinsurance, float MaxValue)>
GetCoinsuranceDataAsync(string membId, string contractId, int medItem);


        Task<long> GetNewApprovalIdAsync();

        Task<string> GetNewClaimIdAsync(string vType);
        Task AddDiagnosesAsync(
                long approvalId,
                List<string> diagnosisIds);

        Task AddServicesAsync(List<ApprovalServiceDto> services);

        Task<double?> GetTotalPriceAsync(long approvalId);
        Task AddLogAsync(ApprovalLogDto logDto);

        Task<bool> HasValidDiagnosisAsync(string diagnosisString);


        Task<List<OnlineServiceItemDto>> GetClaimItemsAsync(long approvalId);

        //ابديت

        Task UpdateApprovalStatusAsync(
    long approvalCode,
    string status,
    string? reason = null);

        Task RejectClaimItemsAsync(
            long approvalCode,
            string reason);

        Task InsertClaimLogAsync(
        int approvalCode,
        int action,
        string message,
        string userName = "Online System");



        Task<List<DiagnosisDto>> GetDiagnosisAsync(
        string? term);


        Task<List<ProductLookupDto>> SearchPharmaProductsAsync(string? term);

        Task<List<ProductLookupDto>> SearchContractServicesAsync(string? term);

        Task<OnlineUserDTO?> GetUserByIdAsync(string userId);

        Task<List<ApprovalDetailDto>> GetBranchApprovalsAsync(string? term);
        Task<List<ApprovalDetailDto>> GetmainBranchApprovalsAsync(string? term);
        Task<bool?> GetUserStatus(string userId);
        Task<List<ApprovalDetailDto>> GetmainBranch3mApprovalsAsync(string? term); 
        Task<List<ApprovalDetailDto>> GetBranch3mApprovalsAsync(string? term);
    }


}
