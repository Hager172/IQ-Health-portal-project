using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class ChatMessage
    {
        public long Id { get; set; }

        public string SenderId { get; set; } = default!;

        public string ReceiverId { get; set; } = default!;

        public string Message { get; set; } = default!;

        public DateTime SentAt { get; set; }
    }
}
