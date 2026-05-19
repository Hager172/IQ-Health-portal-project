using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.Approvals.Queries
{
    public class GetApprovalDetailQuery: IRequest<ApprovalDetailDto?>
    {
        public long ApprovalId { get; set; }

        public GetApprovalDetailQuery(long approvalId)
        {
            ApprovalId = approvalId;
        }
    }
}
