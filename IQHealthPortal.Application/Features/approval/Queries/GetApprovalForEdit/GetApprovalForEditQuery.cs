using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetApprovalForEdit
{
    public class GetApprovalForEditQuery
        : IRequest<ServiceResponse<GetApprovalForEditDto>>
    {
        public string ApprovalNumber { get; set; }

        public GetApprovalForEditQuery(string approvalNumber)
        {
            ApprovalNumber = approvalNumber;
        }
    }
}
