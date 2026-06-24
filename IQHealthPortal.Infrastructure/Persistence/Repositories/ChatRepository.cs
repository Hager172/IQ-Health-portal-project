using IQHealthPortal.Application.Features.Chat.Queries.GetConversations;
using IQHealthPortal.Application.Features.Chat.Queries.GetMessages;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Services.Identity.Services;
using Microsoft.EntityFrameworkCore;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class ChatRepository : IChatRepository
    {
        // Chat is always persisted to the acms_migration database
        // (ConnectionStrings key "2"), regardless of the caller's tenant/auth state.
        private const string ChatClientId = "2";

        private readonly IConnectionStringProvider _connectionStringProvider;

        public ChatRepository(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        private ApplicationDbContext CreateContext()
        {
            var connection = _connectionStringProvider.GetConnectionString(ChatClientId);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connection)
                .Options;

            return new ApplicationDbContext(options);
        }

        public async Task AddMessageAsync(
            string senderId,
            string receiverId,
            string message)
        {
            using var context = CreateContext();

            context.ChatMessages.Add(new ChatMessage
            {
                Sender = senderId,
                Receiver = receiverId,
                Message = message,
                SentAt = DateTime.UtcNow
            });

            await context.SaveChangesAsync();
        }

        public async Task<List<ChatMessageDto>> GetMessagesAsync(
            string senderId,
            string receiverId)
        {
            using var context = CreateContext();

            // Both directions of the conversation, oldest first.
            return await context.ChatMessages
                .Where(m =>
                    (m.Sender == senderId && m.Receiver == receiverId) ||
                    (m.Sender == receiverId && m.Receiver == senderId))
                .OrderBy(m => m.SentAt)
                .Select(m => new ChatMessageDto
                {
                    Id = m.Id,
                    SenderId = m.Sender,
                    ReceiverId = m.Receiver,
                    Message = m.Message,
                    SentAt = m.SentAt
                })
                .ToListAsync();
        }

        public async Task<List<ConversationDto>> GetConversationsAsync(string userId)
        {
            using var context = CreateContext();

            // Every message the user is part of, newest first.
            var messages = await context.ChatMessages
                .Where(m => m.Sender == userId || m.Receiver == userId)
                .OrderByDescending(m => m.SentAt)
                .ToListAsync();

            // Group by the other party; keep the most recent message per contact.
            return messages
                .GroupBy(m => m.Sender == userId ? m.Receiver : m.Sender)
                .Select(g => new ConversationDto
                {
                    Peer = g.Key,
                    LastMessage = g.First().Message,
                    LastSentAt = g.First().SentAt
                })
                .ToList();
        }
    }
}
