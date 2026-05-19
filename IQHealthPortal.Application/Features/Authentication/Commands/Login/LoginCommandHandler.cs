using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.Authentication.Commands.Login
{
    public class LoginCommandHandler
       : IRequestHandler<LoginCommand, ServiceResponse<LoginResponseDto>>
    {
        private readonly IIdentityService _identityService;
        private readonly IIdentityService _IdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public LoginCommandHandler(
            IIdentityService identityService,
           
            IUnitOfWork unitOfWork)
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
                var (isValid, userId) =
                    await _identityService.ValidateUserAsync(
                        request.UserName.Trim(),
                        request.Password);

                if (!isValid || userId == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "Invalid Credentials";
                    serviceResponse.MessageAr = "اسم المستخدم أو كلمة المرور غير صحيحة";
                    return serviceResponse;
                }

                // Get client defaoult
                var client = await _unitOfWork
                    .IdentityRepository<OnlineUserClient>()
                    .FindAsync(x => x.UserId == userId && x.IsDefault);

                //Get clients
                var OnlineClients = await _unitOfWork
                    .IdentityRepository<OnlineClient>()
                    .FindAllAsync();
                var clients= OnlineClients.Select(x => new OnlineClientDto
                {
                    ClientId = x.ClientId,
                    ClientName = x.ClientName,
                    IsActive = x.IsActive
                }).ToList();
                // Get roles
                var roles = await _identityService.GetUserRolesAsync(userId);

                // Generate JWT
                var token = await _identityService.CreateJwtTokenAsync(userId, client);

                var refreshToken = _identityService.GenerateRefreshToken();

                var pages = await _unitOfWork.PageRepository.GetUserPagesAsync(userId,client.ClientId);



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
