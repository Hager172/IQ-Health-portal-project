using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Commands.addapproval
{
    public class CreateClaimCommand : IRequest<CreateClaimResponseDto>
    {
        public ClaimDto Claim { get; set; }

        public OnlineUserDTO CurrentUser { get; set; }
    }
}
