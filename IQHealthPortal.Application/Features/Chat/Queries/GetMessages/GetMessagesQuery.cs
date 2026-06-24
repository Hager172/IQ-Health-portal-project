using System.Collections.Generic;
using MediatR;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetMessages
{
    public class GetMessagesQuery : IRequest<List<ChatMessageDto>>
    {
        public string SenderId { get; set; } = default!;

        public string ReceiverId { get; set; } = default!;

        public string ClientId { get; set; } = default!;
    }
}
