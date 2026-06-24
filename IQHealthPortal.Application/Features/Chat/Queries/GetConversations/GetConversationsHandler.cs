using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetConversations
{
    public class GetConversationsHandler
        : IRequestHandler<GetConversationsQuery, List<ConversationDto>>
    {
        private readonly IChatRepository _chatRepository;

        public GetConversationsHandler(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<List<ConversationDto>> Handle(
            GetConversationsQuery request,
            CancellationToken cancellationToken)
        {
            return await _chatRepository.GetConversationsAsync(request.UserId);
        }
    }
}
