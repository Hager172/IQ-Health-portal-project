using IQHealthPortal.Application.Features.Chat.Commands.SendMessage;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace IQHealthPortal.Infrastructure.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IMediator _mediator;

        public ChatHub(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendMessage(
            string senderId,
            string receiverId,
            string message)
        {
            await _mediator.Send(new SendMessageCommand
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Message = message
            });

            await Clients.All.SendAsync(
                "ReceiveMessage",
                senderId,
                receiverId,
                message);
        }
    }
}
