using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Features.Approvals.Queries;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
namespace IQHealthPortal.Application.Features.Approvals.Queries
{
    public class GetApprovalDetailQueryHandler : IRequestHandler<GetApprovalDetailQuery, ApprovalDetailDto?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetApprovalDetailQueryHandler> _logger;
        private readonly IIdentityService _identityService;
     

        public GetApprovalDetailQueryHandler(IIdentityService identityService,
           IUnitOfWork unitOfWork,
           ILogger<GetApprovalDetailQueryHandler> logger)
        {
            _identityService = identityService;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<ApprovalDetailDto?> Handle(GetApprovalDetailQuery request, CancellationToken cancellationToken)
        {
            try
            {
              // var userId = await _identityService.GetUserIdAsync();
                var (userId, vendorId, branchId) = await _identityService.GetUserInfoAsync();
                if (userId == null)
                {
                    _logger.LogWarning("wrong user");

                }
             
                
               
                // _logger.LogInformation("Fetching approval details for ApprovalId: {ApprovalId}", request.ApprovalId);
               
                var result = await _unitOfWork.ApprovalRepository.GetApprovalDetailDtoAsync(request.ApprovalId);
                if (result == null)
                {
                    _logger.LogWarning("Approval not found: {ApprovalId}", request.ApprovalId);
                    return null;
                }
                if (result.VendorId.StartsWith("Ph0085") ==true && vendorId.StartsWith("Ph")==true )
                {
                    return result;
                }
                else if (result.v_branch_id != null && branchId != null)
                {
                    if (result.v_branch_id == branchId.ToString())
                    {
                        return result;
                    }
                    else
                    {
                        _logger.LogWarning("Approval not found for that Vendor");
                    }
                    
                }
                else if (result.VendorId == vendorId)
                {
                    return result;
                }
                else if (result == null)
                {
                    _logger.LogWarning("Approval not found for ApprovalId: {ApprovalId}", request.ApprovalId);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching approval details for ApprovalId: {ApprovalId}", request.ApprovalId);
                throw;
            }
        }
    }
}

