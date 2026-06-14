using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;

namespace IQHealthPortal.Application.Features.approval.Commands.UpdateClaims
{
    // Returns the legacy result code as a string: "1" (success, generate_remaining_items > 100),
    // "0" (updated but code <= 100), or "-1" (validation failed or unauthorized role).
    public class UpdateClaimsCommand : IRequest<ServiceResponse<string>>
    {
        public UpdateClaimsRequestDto Request { get; set; } = null!;

        public OnlineUserDTO CurrentUser { get; set; } = null!;
    }
}
