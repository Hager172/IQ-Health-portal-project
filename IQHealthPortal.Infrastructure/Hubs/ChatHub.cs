using System.Collections.Generic;
using IQHealthPortal.Application.Features.Chat.Commands.SendMessage;
using IQHealthPortal.Application.Features.Chat.Queries.GetConversations;
using IQHealthPortal.Application.Features.Chat.Queries.GetMessages;
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
            string message,
            string clientId)
        {
            await _mediator.Send(new SendMessageCommand
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Message = message,
                ClientId = clientId
            });

            await Clients.All.SendAsync(
                "ReceiveMessage",
                senderId,
                receiverId,
                message);
        }

        // Returns the stored conversation history between two users
        // (from acms_migration). The widget calls this on open.
        public async Task<List<ChatMessageDto>> GetMessages(
            string senderId,
            string receiverId,
            string clientId)
        {
            return await _mediator.Send(new GetMessagesQuery
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                ClientId = clientId
            });
        }

        // Returns the caller's inbox: one entry per chat partner with the last
        // message/time (newest first). The agent UI calls this to build the
        // sender-grouped contact list.
        public async Task<List<ConversationDto>> GetConversations(
            string userId,
            string clientId)
        {
            return await _mediator.Send(new GetConversationsQuery
            {
                UserId = userId,
                ClientId = clientId
            });
        }
    }
}
