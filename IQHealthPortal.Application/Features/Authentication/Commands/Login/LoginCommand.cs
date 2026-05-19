using IQHealthPortal.Application.Common.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.Authentication.Commands.Login
{
    public class LoginCommand : IRequest<ServiceResponse<LoginResponseDto>>
    {

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
