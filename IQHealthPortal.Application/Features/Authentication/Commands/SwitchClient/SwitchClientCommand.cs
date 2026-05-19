using IQHealthPortal.Application.Common.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.User.SwitchClient
{
    public class SwitchClientCommand : IRequest<ServiceResponse< SwitchClientCommandResponse>>
    {
        public int ClientId { get; set; }
    }
}
