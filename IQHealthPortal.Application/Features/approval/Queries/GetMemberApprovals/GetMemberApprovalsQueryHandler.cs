using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetMemberApprovals
{
    public class GetMemberApprovalsQueryHandler
        : IRequestHandler<GetMemberApprovalsQuery, ServiceResponse<MemberApprovalsResponseDto>>
    {
        private readonly IUnitOfWork _uow;

        public GetMemberApprovalsQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ServiceResponse<MemberApprovalsResponseDto>> Handle(
            GetMemberApprovalsQuery request,
            CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<MemberApprovalsResponseDto>();

            var approvals = await _uow.ApprovalRepository
                .GetByMemberIdAsync(request.MemberId);

            response.Data = new MemberApprovalsResponseDto
            {
                MemberId = request.MemberId,
                Approvals = approvals
            };

            response.Success = true;
            response.Status = 200;

            return response;
        }
    }
}
