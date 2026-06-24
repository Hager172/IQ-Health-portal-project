using MediatR;

namespace IQHealthPortal.Application.Features.Chat.Commands.SendMessage
{
    public class SendMessageCommand : IRequest<bool>
    {
        public string SenderId { get; set; } = default!;

        public string ReceiverId { get; set; } = default!;

        public string Message { get; set; } = default!;
        public string ClientId { get; set; } = default!;
    }
}
