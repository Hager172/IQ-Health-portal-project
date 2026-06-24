using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq; // تم إضافتها لضمان عمل Select و Distinct و FirstOrDefault بدون مشاكل
using System.Text;
using System.Threading; // ✅ تم إضافتها لحل مشكلة CancellationToken
using System.Threading.Tasks; // ✅ تم إضافتها لحل مشكلة Task

namespace IQHealthPortal.Application.Features.Authentication.Commands.Login
{
    public class LoginCommandHandler
       : IRequestHandler<LoginCommand, ServiceResponse<LoginResponseDto>>
    {
        private readonly IIdentityService _identityService;
        private readonly IUnitOfWork _unitOfWork;

        public LoginCommandHandler(IIdentityService identityService, IUnitOfWork unitOfWork)
        {
            _identityService = identityService;
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResponse<LoginResponseDto>> Handle(
            LoginCommand request,
            CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<LoginResponseDto>();

            try
            {
                // ✅ Validate user using IdentityService
                var (isValid, userId) = await _identityService.ValidateUserAsync(
                        request.UserName.Trim(),
                        request.Password);

                if (!isValid || userId == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "Invalid Credentials";
                    serviceResponse.MessageAr = "اسم المستخدم أو كلمة المرور غير صحيحة";
                    return serviceResponse;
                }

                var status = await _unitOfWork.ClaimRepository.GetUserStatus(userId);
                if (status != true)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "User is inactive";
                    serviceResponse.MessageAr = "المستخدم غير نشط";
                    return serviceResponse;
                }

                // merged users
                var mergedUsers = await _unitOfWork
                    .IdentityRepository<AspNetUsersMerge>()
                    .FindAllAsync(x => (x.UserId == userId || x.UserId1 == userId));

                // all userid's in all clients 
                var allUserIds = new List<string> { userId };

                foreach (var item in mergedUsers)
                {
                    var user1Status = await _unitOfWork.ClaimRepository.GetUserStatus(item.UserId);
                    var user2Status = await _unitOfWork.ClaimRepository.GetUserStatus(item.UserId1);

                    if (user1Status == true)
                        allUserIds.Add(item.UserId);

                    if (user2Status == true)
                        allUserIds.Add(item.UserId1);
                }

                allUserIds = allUserIds.Distinct().ToList();

                // Get client default
                var client = await _unitOfWork
                    .IdentityRepository<OnlineUserClient>()
                    .FindAsync(x => x.UserId == userId);

                // Get clients
                var userClients = await _unitOfWork
                     .IdentityRepository<OnlineUserClient>()
                     .FindAllAsync(
                         x => allUserIds.Contains(x.UserId),
                         new[] { "OnlineClient" }
                     );

                var clients = userClients.Select(x => new OnlineClientDto
                {
                    ClientId = x.ClientId,
                    ClientName = x.OnlineClient.ClientName,
                    IsActive = x.OnlineClient.IsActive,
                    UserId = x.UserId
                }).ToList();

                // Get roles
                var roles = await _identityService.GetUserRolesAsync(userId);

                // Generate JWT
                var token = await _identityService.CreateJwtTokenAsync(userId, client);

                var refreshToken = _identityService.GenerateRefreshToken();

                var pages = await _unitOfWork.PageRepository.GetUserPagesAsync(userId, client.ClientId);

                var loginResponse = new LoginResponseDto
                {
                    Username = request.UserName,
                    VendorId = client?.VendorId,
                    BranchId = client?.BranchId?.ToString(),
                    ClientId = client.ClientId,
                    Roles = roles,
                    Pages = pages,
                    Clients = clients,
                    IsAuthenticated = true,
                    AuthToken = token.Token,
                    ExpiresIn = token.Expiration,
                    RefreshToken = refreshToken.Token,
                    RefreshTokenExpiration = refreshToken.ExpiresOn,
                    MessageEn = "Login successful",
                    MessageAr = "تم تسجيل الدخول بنجاح",
                };

                serviceResponse.Data = loginResponse;
                serviceResponse.Success = true;
                serviceResponse.MessageEn = "Login successful";
                serviceResponse.MessageAr = "تم تسجيل الدخول بنجاح";
            } 
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.MessageEn = ex.Message;
            }

            return serviceResponse;
        }
    }
}