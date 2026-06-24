using System;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetMessages
{
    public class ChatMessageDto
    {
        public long Id { get; set; }

        public string? SenderId { get; set; }

        public string? ReceiverId { get; set; }

        public string? Message { get; set; }

        public DateTime? SentAt { get; set; }
    }
}
