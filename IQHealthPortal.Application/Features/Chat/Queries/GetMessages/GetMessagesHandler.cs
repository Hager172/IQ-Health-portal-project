using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetMessages
{
    public class GetMessagesHandler
        : IRequestHandler<GetMessagesQuery, List<ChatMessageDto>>
    {
        private readonly IChatRepository _chatRepository;

        public GetMessagesHandler(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<List<ChatMessageDto>> Handle(
            GetMessagesQuery request,
            CancellationToken cancellationToken)
        {
            return await _chatRepository.GetMessagesAsync(
                request.SenderId,
                request.ReceiverId);
        }
    }
}
