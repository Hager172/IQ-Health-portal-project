
using IQHealthPortal.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Infrastructure.MeddleWare
{
    public class ClientConnectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration  _configuration;

        public ClientConnectionMiddleware(RequestDelegate next , IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
         {
            var authHeader = context.Request.Headers["Authorization"].ToString();
            Console.WriteLine($"Authorization Header: {authHeader}");


            if (context.User.Identity.IsAuthenticated)
            {
                var clientId = context.User.FindFirst("ClientId")?.Value;
                Console.WriteLine($"Authenticated ClientId: {clientId}");

                var unitOfWork = context.RequestServices.GetRequiredService<IUnitOfWork>();

                // Logic for switching the connection string
                if (!string.IsNullOrEmpty(clientId))
                {
                    unitOfWork.SetConnectionString(clientId);
                }
            }
            else
            {
                Console.WriteLine("User is not authenticated");
            }
            await _next(context);
        }
    }
}
