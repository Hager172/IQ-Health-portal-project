using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetMemberInfo
{
    public class GetMemberInfoQueryHandler : IRequestHandler<GetMemberInfoQuery, MemberInfoDto>
    {
        private readonly IClaimService _ClaimService;

        public GetMemberInfoQueryHandler(IClaimService ClaimService)
        {
            _ClaimService = ClaimService;
        }

        public async Task<MemberInfoDto?> Handle(
            GetMemberInfoQuery request,
            CancellationToken cancellationToken)
        {
            return await _ClaimService.GetMemberInfoAsync(
                request.MemberId,
                request.Type);
        }
    }
}
