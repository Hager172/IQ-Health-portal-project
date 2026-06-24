using System.Collections.Generic;
using IQHealthPortal.Application.Features.Chat.Queries.GetConversations;
using IQHealthPortal.Application.Features.Chat.Queries.GetMessages;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IChatRepository
    {
        Task AddMessageAsync(
            string senderId,
            string receiverId,
            string message);

        Task<List<ChatMessageDto>> GetMessagesAsync(
            string senderId,
            string receiverId);

        Task<List<ConversationDto>> GetConversationsAsync(string userId);
    }
}
