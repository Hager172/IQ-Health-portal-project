using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Application.ApprovalService.Queries.GetApproval
{
    public class GetApprovalQuery : IRequest<GetApprovalDetailsQuery>
    {
        public long ApprovalId { get; set; }
    }
}
