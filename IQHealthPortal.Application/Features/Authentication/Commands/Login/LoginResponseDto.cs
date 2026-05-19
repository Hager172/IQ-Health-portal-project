
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Auth.DTOs;
using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.Authentication.Commands.Login
{
    public class LoginResponseDto
    {
        public string? Username { get; set; }
        public bool IsPharma { get; set; } = false;
        public string VendorId { get; set; }
        public string BranchId { get; set; }
        public int ClientId { get; set; }
        public List<string>? Roles { get; set; }
      
       
        public List<OnlineClientDto> Clients { get; set; }
        public List<PageDto> Pages { get; set; }
        public string? AuthToken { get; set; }
        public DateTime? ExpiresIn { get; set; }

        //[JsonIgnore]
        public string? RefreshToken { get; set; }
      
    
        public string? MessageEn { get; set; }
        public string? MessageAr { get; set; }
        public bool IsAuthenticated { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
