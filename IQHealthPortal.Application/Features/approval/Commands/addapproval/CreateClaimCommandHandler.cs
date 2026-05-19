using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.services;

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
namespace IQHealthPortal.Application.Features.approval.Commands.addapproval
{
    public class CreateClaimCommandHandler : IRequestHandler<
        CreateClaimCommand,
        CreateClaimResponseDto>
    {
        private readonly IClaimService claimService;
        public CreateClaimCommandHandler(
             IClaimService claimService)
        {
            this.claimService = claimService;
        }

        public async Task<CreateClaimResponseDto> Handle(
            CreateClaimCommand request,
            CancellationToken cancellationToken)
        {
            var claim = request.Claim;

            var user = request.CurrentUser;

            // STEP 1 — PRE VALIDATION
            var isValid =
                await claimService.ValidateClaimAsync(
                    claim,
                    user);

            if (!isValid)
            {
                return new CreateClaimResponseDto
                {
                    Success = false,
                    Message = claim.MsgHolder
                };
            }

            // STEP 2 — SAVE CLAIM
            var saved =
                await claimService.SaveClaimAsync(
                    claim,
                    user);

            if (!saved)
            {
                return new CreateClaimResponseDto
                {
                    Success = false,
                    Message = "Failed To Save Claim"
                };
            }

            // STEP 3 — AFTER VALIDATION
            ClaimResultDto result;

            switch (user.VType)
            {
                case "Ph":

                    result =
                        await claimService
                            .ValidateClaimAfterAsync(claim);

                    break;

                case "LR":
                case "Sc":
                case "Lb":
                case "Rd":
                case "Dt":

                    // لسه هتعمليها
                    result =
                        await claimService
                            .ValidateClaimAfterAsync(claim);

                    break;

                default:

                    result = new ClaimResultDto
                    {
                        Result = "Pending"
                    };

                    break;
            }

            // STEP 4 — RESPONSE
            return new CreateClaimResponseDto
            {
                Success = true,
                Message = "Claim Created Successfully",
                Result = result
            };
        }
    }
}
