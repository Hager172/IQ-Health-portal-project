using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetMemberApprovals
{
    public class GetMemberApprovalsQuery
        : IRequest<ServiceResponse<MemberApprovalsResponseDto>>
    {
        public string MemberId { get; set; }

        public GetMemberApprovalsQuery(string memberId)
        {
            MemberId = memberId;
        }
    }
}
