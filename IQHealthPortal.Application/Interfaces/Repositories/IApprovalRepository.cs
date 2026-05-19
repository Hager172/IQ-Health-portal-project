using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IApprovalRepository
    {
        Task<List<MemberApprovalListDto>> GetByMemberIdAsync(string memberId);

        Task<GetApprovalForEditDto?> GetApprovalForEditAsync(string approvalNumber);

        Task UpdateApprovalItemsAsync(string approvalNumber,
            List<ApprovalItemDto> items);
        Task<ApprovalDetailDto?> GetApprovalDetailDtoAsync(long approvalId);

        Task<List<ApprovalTodatDTO>> GetAllTodayApprovals(string client_id, string VendorId);
        Task<List<ApprovalTodatDTO>> Getnotcompeleteapp(string client_id, string VendorId);

        Task AddApprovalAsync(ApprovalClaimDto approval);
    }
}
