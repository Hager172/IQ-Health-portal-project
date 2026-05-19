using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Auth.DTOs
{
    public class JwtTokenDto
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
    }
}
