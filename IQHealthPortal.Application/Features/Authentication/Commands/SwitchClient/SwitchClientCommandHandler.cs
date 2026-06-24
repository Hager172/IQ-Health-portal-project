//using  ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
//using ACMS_ONLINE_APPLICATION.User.Auth;
//using ACMS_ONLINE_APPLICATION.User.Login;
//using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.IdentityModel.Tokens.Jwt;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;
//using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;

//namespace ACMS_ONLINE_APPLICATION.User.SwitchClient
//{
//    public class SwitchClientCommandHandler : IRequestHandler<SwitchClientCommand, ServiceResponse<SwitchClientCommandResponse>>
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;
//        private readonly IAuthService _authService;
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IHttpContextAccessor _contextAccessor;
//        public SwitchClientCommandHandler
//            (   UserManager<ApplicationUser> userManager,
//                SignInManager<ApplicationUser> signInManager,
//                IAuthService authService,
//                IUnitOfWork unitOfWork,
//                IHttpContextAccessor contextAccessor
//            )
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _authService = authService;
//            _unitOfWork = unitOfWork;
//            _contextAccessor = contextAccessor;
//        }

//        public async Task<ServiceResponse<SwitchClientCommandResponse>> Handle(SwitchClientCommand request, CancellationToken cancellationToken)
//        {
//            var serviceResponse = new ServiceResponse<SwitchClientCommandResponse>();

//            try
//            {
//                var UserId = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
//                var client = await _unitOfWork.OnlineUserClientRepository.FindAsync(x => x.UserId == UserId && x.ClientId == request.ClientId);
//                if (client == null)
//                {
//                    serviceResponse.Success = false;
//                    serviceResponse.Status = -1;
//                    throw new Exception("Client Not Found");

//                }
//                //var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == UserId);
//                var user = await _userManager.FindByIdAsync( UserId);

//                if (user == null)
//                {
//                    serviceResponse.Success = false;
//                    serviceResponse.Status = -2;
//                    throw new Exception("User Not Found");
//                }

//                var token = await _authService.CreateJwtToken(user, client);

//                var switchClient = new SwitchClientCommandResponse()
//                {
//                    Username = user.UserName,
//                    BranchId = client.BranchId.ToString(),
//                    VendorId = client.VendorId,
//                    IsAuthenticated = true,
//                    AuthToken = new JwtSecurityTokenHandler().WriteToken(token),

//                };


//                serviceResponse.Data = switchClient;
//            }
//            catch (Exception ex)
//            {
//                serviceResponse.MessageAr = "";
//            }

//            return serviceResponse;
//        }
//    }
//}
using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using MediatR;

using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ACMS_ONLINE_APPLICATION.User.SwitchClient
{
    public class SwitchClientCommandHandler
        : IRequestHandler<SwitchClientCommand, ServiceResponse<SwitchClientCommandResponse>>
    {
        private readonly IIdentityService _identityService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;

        public SwitchClientCommandHandler(
            IIdentityService identityService,
            IUnitOfWork unitOfWork,
            IHttpContextAccessor contextAccessor)
        {
            _identityService = identityService;
            _unitOfWork = unitOfWork;
            _contextAccessor = contextAccessor;
        }

        public async Task<ServiceResponse<SwitchClientCommandResponse>> Handle(
            SwitchClientCommand request,
            CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<SwitchClientCommandResponse>();

            try
            {
                var userId = request.UserId;

                if (string.IsNullOrEmpty(userId))
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "User not authenticated";
                    return serviceResponse;
                }
                var currentUserId = _contextAccessor.HttpContext?
    .User.FindFirstValue(ClaimTypes.NameIdentifier);


                var isMerged = await _unitOfWork
                    .IdentityRepository<AspNetUsersMerge>()
                    .FindAsync(x =>
                        (x.UserId == currentUserId && x.UserId1 == request.UserId)
                        ||
                        (x.UserId1 == currentUserId && x.UserId == request.UserId)
                    );


                if (currentUserId != request.UserId && isMerged == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "Invalid merged user";
                    return serviceResponse;
                }
                // ✅ Check client exists for this user
                var client = await _unitOfWork
                    .IdentityRepository<OnlineUserClient>()
                    .FindAsync(x => x.UserId == userId && x.ClientId == request.ClientId);

                if (client == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.MessageEn = "Client not found";
                    return serviceResponse;
                }

                // ✅ Generate JWT باستخدام نفس اللوجيك بتاع اللوجن
                var token = await _identityService.CreateJwtTokenAsync(userId, client);

                // ✅ response
                var switchClient = new SwitchClientCommandResponse()
                {
                    Username = _contextAccessor.HttpContext?.User.Identity?.Name,
                    BranchId = client.BranchId?.ToString(),
                    VendorId = client.VendorId,
                    IsAuthenticated = true,
                    Roles = await _identityService.GetUserRolesAsync(userId),
                    AuthToken = token.Token,
                };

                serviceResponse.Data = switchClient;
                serviceResponse.Success = true;
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
