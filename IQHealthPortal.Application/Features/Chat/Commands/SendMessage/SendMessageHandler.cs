using IQHealthPortal.Domain.Identity.Entities;
using MediatR;


namespace IQHealthPortal.Application.Features.Chat.Commands.SendMessage
{
    public class SendMessageHandler
    : IRequestHandler<SendMessageCommand, bool>
    {
        private readonly IUnitOfWork _context;

        public SendMessageHandler(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            SendMessageCommand request,
            CancellationToken cancellationToken)
        {
            var message = new ChatMessage
            {
                SenderId = request.SenderId,
                ReceiverId = request.ReceiverId,
                Message = request.Message,
                SentAt = DateTime.UtcNow
            };

            await _context.ChatMessages.AddAsync(
                message,
                cancellationToken);

            await _context.SaveChangesAsync(
                cancellationToken);

            return true;
        }
    }
}
