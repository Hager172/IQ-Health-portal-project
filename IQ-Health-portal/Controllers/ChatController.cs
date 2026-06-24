using IQHealthPortal.Application.Features.Chat.Queries.GetConversations;
using IQHealthPortal.Application.Features.Chat.Queries.GetMessages;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IQ_Health_portal.Controllers
{
   
    [ApiController]
    [Route("api/chat")]
    public class ChatController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChatController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("history")]
        public async Task<IActionResult> History([FromQuery] string peer)
        {
            var me = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var clientId = User.FindFirst("ClientId")?.Value ?? string.Empty;

            if (string.IsNullOrEmpty(me) || string.IsNullOrEmpty(peer))
                return Ok(Array.Empty<object>());

            var messages = await _mediator.Send(new GetMessagesQuery
            {
                SenderId = me,
                ReceiverId = peer,
                ClientId = clientId
            });

            return Ok(messages);
        }

        [HttpGet("conversations")]
        public async Task<IActionResult> Conversations()
        {
            var me = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var clientId = User.FindFirst("ClientId")?.Value ?? string.Empty;

            if (string.IsNullOrEmpty(me))
                return Ok(Array.Empty<object>());

            var conversations = await _mediator.Send(new GetConversationsQuery
            {
                UserId = me,
                ClientId = clientId
            });

            return Ok(conversations);
        }
    }
}
