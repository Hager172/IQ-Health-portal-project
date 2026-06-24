using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.Features.Authentication.Commands.Login;
using IQHealthPortal.Application.ApprovalService.Queries.GetApproval;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ACMS_ONLINE_APPLICATION.User.SwitchClient;
using IQHealthPortal.Infrastructure.UserService.Queries.GetUserData;

namespace IQ_Health_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
       

        public AccountController( IMediator mediator)
        {
            _mediator = mediator;
      
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var result = await _mediator.Send(command);


            return Ok(result);


        }


        //[Authorize]
        //[HttpPost("SwitchClients", Name = "SwitchClients")]
        //public async Task<ActionResult<ServiceResponse<GetApprovalDetailsQuery>>> SwitchClients([FromQuery] int ClientId)
        //{


        //    var SwitchClientCommand = new SwitchClientCommand() { ClientId = ClientId };
        //    return Ok(await _mediator.Send(SwitchClientCommand));
        //}
        [Authorize]
        [HttpPost("SwitchClients", Name = "SwitchClients")]
        public async Task<ActionResult<ServiceResponse<SwitchClientCommandResponse>>> SwitchClients(
    [FromQuery] string UserId,
    [FromQuery] int ClientId)
        {
            var command = new SwitchClientCommand
            {
                UserId = UserId,
                ClientId = ClientId
            };

            return Ok(await _mediator.Send(command));
        }

        [Authorize]
        [HttpGet("Me", Name = "Me")]
        public async Task<ActionResult<ServiceResponse<GetUserDataQueryResponse>>> Me()
        {
            var GetuserDataQuery = new GetuserDataQuery() { };
            return Ok(await _mediator.Send(GetuserDataQuery));
        }


    }
}
