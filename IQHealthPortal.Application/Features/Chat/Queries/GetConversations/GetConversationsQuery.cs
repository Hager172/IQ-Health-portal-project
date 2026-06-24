using System.Collections.Generic;
using MediatR;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetConversations
{
    public class GetConversationsQuery : IRequest<List<ConversationDto>>
    {
        // The current user (e.g. the online agent) whose inbox we are building.
        public string UserId { get; set; } = default!;

        public string ClientId { get; set; } = default!;
    }
}
