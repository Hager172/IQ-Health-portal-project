using System;

namespace IQHealthPortal.Application.Features.Chat.Queries.GetConversations
{
    public class ConversationDto
    {
        // The other party in the conversation (the contact shown in the inbox).
        public string? Peer { get; set; }

        public string? LastMessage { get; set; }

        public DateTime? LastSentAt { get; set; }
    }
}
