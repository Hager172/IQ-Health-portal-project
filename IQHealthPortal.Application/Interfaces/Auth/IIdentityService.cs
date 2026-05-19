

using IQHealthPortal.Application.Interfaces.Auth.DTOs;
using IQHealthPortal.Application.User.Dto;
using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Auth
{
    public interface IIdentityService
    {


        Task<JwtTokenDto> CreateJwtTokenAsync(string userid, OnlineUserClient? userClient);



        RefreshTokenDto GenerateRefreshToken();


        public string GetUserCurrentClient();

        public Task<List<UserClientDto>> GetUserClientList(string userId);
        Task<(string UserId, string VendorId, string? BranchId)> GetUserInfoAsync();

        Task<(bool IsSuccess, string? UserId)> ValidateUserAsync(string name, string password);
        Task<List<string>> GetUserRolesAsync(string userId);
       

        }
    }
