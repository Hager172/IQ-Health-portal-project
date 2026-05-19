using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetNotCompeleteApp
{
    public class GetNotCompeleteAppQuery : IRequest<ServiceResponse<GetTodayapps>>
    
    {
        public string? clientid { get; set; }
        public string? vendorid { get; set; }
        public GetNotCompeleteAppQuery(string client_idc, string? vendorid)
        {
            this.clientid = client_idc;
            this.vendorid = vendorid;
        }

    }
}
