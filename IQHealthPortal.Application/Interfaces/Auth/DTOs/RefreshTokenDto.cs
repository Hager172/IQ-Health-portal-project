using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Auth.DTOs
{
    public class RefreshTokenDto
    {
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresOn { get; set; }
        public bool IsRevoked { get; set; } = false;
    }
}
