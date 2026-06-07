using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.Getbranchapproval
{
    public class GetbranchapprovalHander : IRequestHandler<GetbranchapprovalQuery, List<ApprovalDetailDto>>
    {
        private readonly IClaimService _ClaimService;
        public GetbranchapprovalHander(IClaimService claimService)
        {
            _ClaimService = claimService;
        }

        public async Task<List<ApprovalDetailDto>> Handle(GetbranchapprovalQuery request, CancellationToken cancellationToken)
        {
            return await _ClaimService.getbranchapproval(request.branchid);

        }
    }
}
