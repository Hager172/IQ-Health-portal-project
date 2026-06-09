using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.Getbranchapproval
{
    public class GetbranchapprovalQuery :IRequest<List<ApprovalDetailDto>>
    {
      public  string? branchid { get; set; }
    }
}
