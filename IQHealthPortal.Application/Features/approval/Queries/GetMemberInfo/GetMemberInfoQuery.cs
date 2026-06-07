using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetMemberInfo
{
    public class GetMemberInfoQuery : IRequest<MemberInfoDto>
    {
        public string MemberId { get; set; }
        public string Type { get; set; }
    }
}
