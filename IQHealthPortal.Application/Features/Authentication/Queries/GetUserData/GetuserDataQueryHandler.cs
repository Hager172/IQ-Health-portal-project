
using AutoMapper;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Auth;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Infrastructure.UserService.Queries.GetUserData
{
    public class GetuserDataQueryHandler : IRequestHandler<GetuserDataQuery,GetUserDataQueryResponse>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly IAuthService _authService;
        private readonly IIdentityService _authService;

        public GetuserDataQueryHandler(IUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IIdentityService authService)
        {
            _httpContextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _authService = authService;
        }


        public async Task<GetUserDataQueryResponse> Handle(GetuserDataQuery request, CancellationToken cancellationToken)
        {
            //var serviceResponse = new ServiceResponse<GetUserDataQueryResponse>();

            try
            {




               

                // Fetch the currently logged-in user
                var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
                if (user == null)
                    throw new Exception("User not found.");

                // Fetch user roles
                var userRoles = await _userManager.GetRolesAsync(user);
                if (!userRoles.Any())
                    throw new Exception("No roles assigned to the user.");

                // Fetch role IDs for the user's roles
                var roleIds = await _roleManager.Roles
                                                 .Where(role => userRoles.Contains(role.Name))
                                                 .Select(role => role.Id)
                                                 .ToListAsync();
                var currentclient = _authService.GetUserCurrentClient();

                // Fetch all privileges for the user's roles
                var privilegeEntities = await _unitOfWork.PrivilegesRepository.FindAllAsync(
                    privilege => roleIds.Contains(privilege.RoleId) && privilege.ClientId.ToString() == currentclient
                                ,
                    includes: new[] { "Page.ParentPage" }
                );

                // Extract and aggregate pages and parent pages
                var allPages = privilegeEntities
                                .Select(privilege => privilege.Page)
                                .Where(page => page != null)
                                .Union(privilegeEntities
                                    .Select(privilege => privilege.Page?.ParentPage)
                                    .Where(parentPage => parentPage != null))
                                .Distinct()
                                .ToList();

                // Construct hierarchical structure for pages
                //var hierarchicalPages = allPages
                //    .Where(page => page.PageParentId == null)
                //    .Select(parentPage => new
                //    {
                //        ParentPage = parentPage,
                //        SubPages = allPages.Where(childPage => childPage.PageParentId == parentPage.Id).ToList()
                //    })
                //    .Select(x => x.ParentPage)
                //    .ToList();
                var hierarchicalPages = await _unitOfWork.PageRepository.GetUserPagesAsync(user.Id, int.Parse(currentclient));

                var CurrentClinetId = _authService.GetUserCurrentClient();
                var clients = _unitOfWork.OnlineUserClientRepository.FindAll(x => x.UserId == user.Id)
       .Join(
           _unitOfWork.OnlineClientRepository.GetAll(),
           userClient => userClient.ClientId,
           client => client.ClientId,
           (userClient, client) => new OnlineUserClientDto
           {
               ClientId = userClient.ClientId,
               ClientName = client.ClientName
           }
       ).ToList();


                // Map the data into the response object
                var userDataResponse = new GetUserDataQueryResponse
                {
                    Id = user.Id!,
                    Username = user.UserName,
                    Fullname = user.UserName, // This could be replaced with a FullName property if available
                    Email = user.Email,
                    Pic = "./assets/media/avatars/blank.png",
                    Roles = userRoles.ToList(), // Map user roles
                    Occupation = "Occupation", // Replace with dynamic data if available
                    CompanyName = "AspirCode", // Replace with dynamic data if available
                    Phone = user.PhoneNumber,
                    Address = new AddressModel(), // Initialize with default or existing user address
                    SocialNetworks = new SocialNetworksModel(), // Initialize with default or existing user social networks
                    Pages = _mapper.Map<List<PageDto>>(hierarchicalPages),
                    // Map hierarchical pages

                    CurrentClinetId = CurrentClinetId,
                    clients = clients

                };

                return userDataResponse;

                // serviceResponse.Data = data;    

                // return data;
            }
            catch (Exception ex)
            {
                var tt = ex.GetBaseException();
            }
            return new GetUserDataQueryResponse();
            // return serviceResponse;
        }

        


    }



}
