using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.services
{
    public interface IClaimService
    {
        Task<bool> ValidateClaimAsync(
            ClaimDto claim,
            OnlineUserDTO user);

        Task<bool> SaveClaimAsync(
            ClaimDto claim,
            OnlineUserDTO user);

        Task<ClaimResultDto> ValidateClaimAfterAsync(
            ClaimDto claim);
    }
}
