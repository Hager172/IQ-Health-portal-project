using IQHealthPortal.Application.ApprovalService.Queries.GetApproval;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Features.approval.Commands.addapproval;
using IQHealthPortal.Application.Features.approval.Commands.UpdateApprovalItems;
using IQHealthPortal.Application.Features.approval.Queries.GetAllTodayApproval;
using IQHealthPortal.Application.Features.approval.Queries.GetApprovalForEdit;
using IQHealthPortal.Application.Features.approval.Queries.Getbranchapproval;
using IQHealthPortal.Application.Features.approval.Queries.GetDiagnosis;
using IQHealthPortal.Application.Features.approval.Queries.GetMemberApprovals;
using IQHealthPortal.Application.Features.approval.Queries.GetMemberInfo;
using IQHealthPortal.Application.Features.approval.Queries.GetNotCompeleteApp;
using IQHealthPortal.Application.Features.approval.Queries.GetProducts;
using IQHealthPortal.Application.Features.Approvals.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQ_Health_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApprovalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("approvals/member/{memberId}")]
        public async Task<IActionResult> GetMemberApprovals(string memberId)
        {
            try
            {
                var result = await _mediator.Send(
                    new GetMemberApprovalsQuery(memberId));

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

        [HttpGet("approvals/edit/{approvalNumber}")]
        public async Task<IActionResult> GetApprovalForEdit(string approvalNumber)
        {
            var result = await _mediator.Send(
                new GetApprovalForEditQuery(approvalNumber));

            return StatusCode(result.Status ?? 200, result);
        }

        [HttpPut("approvalitems/{approvalNumber}")]
        public async Task<IActionResult> UpdateItems(
            string approvalNumber,
            [FromBody] List<ApprovalItemDto> items)
        {
            var result = await _mediator.Send(
                new UpdateApprovalItemsCommand(approvalNumber, items));

            return StatusCode(result.Status ?? 200, result);
        }
        [HttpGet("allapprovaltoday/{client_id}/{vendorid}")]
        public async Task<IActionResult> GetTodayApprovals(string client_id,string vendorid)
        {
            var res = await _mediator.Send(new GetAllTodayApprovalQuery(client_id,vendorid));
            return StatusCode(res.Status ?? 200, res);

        }
        [HttpGet("allapprovalnottoday/{client_id}/{vendorid}")]
        public async Task<IActionResult> GetTodayNotcompeletApprovals(string client_id, string vendorid)
        {
            var res = await _mediator.Send(new GetNotCompeleteAppQuery(client_id, vendorid));
            return StatusCode(res.Status ?? 200, res);

        }

        [HttpGet("{id}/details")]
        public async Task<ActionResult<ApprovalDetailDto>> GetApprovalDetails(long id)
        {
            var result = await _mediator.Send(new GetApprovalDetailQuery(id));

            if (result == null)
                return NotFound($"Approval with ID {id} not found");

            return Ok(result);
        }


        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> CreateClaim(
          [FromBody] ClaimDto claimDto)
        {
            // CURRENT USER
            var currentUser = new OnlineUserDTO
            {
                UserName = User.Identity?.Name,

                Vendor = User.FindFirst("Vendor")?.Value,

                VType = User.FindFirst("VType")?.Value,

                Office = User.FindFirst("Office")?.Value
            };

            // COMMAND
            var command = new CreateClaimCommand
            {
                Claim = claimDto,
                CurrentUser = currentUser
            };

            // SEND
            var result = await _mediator.Send(command);

            // RESPONSE
            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }


        [HttpGet("diagnosis")]
        public async Task<IActionResult> GetDiagnosis(
     string? term)
        {
            var result =
                await _mediator.Send(
                    new GetDiagnosisQuery
                    {
                        Term = term
                    });

            return Ok(result);
        }
      
     
        [HttpGet("products")]
        [Authorize]
        public async Task<IActionResult> GetProducts([FromQuery] string? term, [FromQuery] string vtype)
        {
            var result = await _mediator.Send(new GetProductsquery
            {
                Term = term,
                VType = vtype
            });

            return Ok(result);
        }

        [HttpGet("member-info")]
        [Authorize]
        public async Task<IActionResult> GetMemberInfo(
    [FromQuery] string memberId,
    [FromQuery] string type)
        {
            var result = await _mediator.Send(
                new GetMemberInfoQuery
                {
                    MemberId = memberId,
                    Type = type
                });

            return Ok(result);
        }


        [HttpGet("branch-approvals")]
        [Authorize]
        public async Task<IActionResult> GetBranchApprovals(string? office_id)
        {
            var result = await _mediator.Send(
                new GetbranchapprovalQuery
                {
                    branchid = office_id
                });
            return Ok(result);
        }
    }
}
    
