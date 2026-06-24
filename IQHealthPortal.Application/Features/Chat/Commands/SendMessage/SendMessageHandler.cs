using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;


namespace IQHealthPortal.Application.Features.Chat.Commands.SendMessage
{
    public class SendMessageHandler
    : IRequestHandler<SendMessageCommand, bool>
    {
        private readonly IChatRepository _chatRepository;

        public SendMessageHandler(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<bool> Handle(
            SendMessageCommand request,
            CancellationToken cancellationToken)
        {
            await _chatRepository.AddMessageAsync(
                request.SenderId,
                request.ReceiverId,
                request.Message);

            return true;
        }
    }
}
