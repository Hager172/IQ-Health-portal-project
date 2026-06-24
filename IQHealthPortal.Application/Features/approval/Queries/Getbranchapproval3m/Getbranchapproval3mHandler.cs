using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Features.approval.Queries.Getbranchapproval;
using IQHealthPortal.Application.Interfaces.services;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace IQHealthPortal.Application.Features.approval.Queries.Getbranchapproval3m
{
    public class Getbranchapproval3mHandler : IRequestHandler<Getbranchapproval3mQuery, List<ApprovalDetailDto>>
    {
        private readonly IClaimService _ClaimService;
        public Getbranchapproval3mHandler(IClaimService claimService)
        {
            _ClaimService = claimService;
        }

        public async Task<List<ApprovalDetailDto>> Handle(Getbranchapproval3mQuery request, CancellationToken cancellationToken)
        {
            return await _ClaimService.getbranchapprovallast3monthes(request.branchid);

        }
    }
}

