using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Features.approval.Commands.UpdateClaims;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IQ_Health_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClaimsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("update")]
        [Authorize]
        public async Task<IActionResult> UpdateClaims(
            [FromBody] UpdateClaimsRequestDto request)
        {
            try
            {
                // CURRENT USER (taken from the JWT, not the request body)
                var currentUser = new OnlineUserDTO
                {
                    UserName = User.Identity?.Name,
                    Vendor = User.FindFirst("Vendor")?.Value,
                    VType = User.FindFirst("VType")?.Value,
                    Office = User.FindFirst("Office")?.Value,
                    RoleId = int.TryParse(User.FindFirst("RoleId")?.Value, out var roleId)
                        ? roleId
                        : null
                };

                var result = await _mediator.Send(new UpdateClaimsCommand
                {
                    Request = request,
                    CurrentUser = currentUser
                });

                return StatusCode(result.Status ?? 200, result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }
    }
}
