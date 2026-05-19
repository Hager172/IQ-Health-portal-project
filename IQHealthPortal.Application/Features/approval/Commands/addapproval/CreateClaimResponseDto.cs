using IQHealthPortal.Application.DTOs.ApprovalDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Commands.addapproval
{
    public class CreateClaimResponseDto
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public ClaimResultDto? Result { get; set; }
    }
}
