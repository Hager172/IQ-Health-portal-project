using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Commands.UpdateApprovalItems
{
    public class UpdateApprovalItemsCommand
        : IRequest<ServiceResponse<bool>>
    {
        public string ApprovalNumber { get; set; }
        public List<ApprovalItemDto> Items { get; set; }

        public UpdateApprovalItemsCommand(
            string approvalNumber,
            List<ApprovalItemDto> items)
        {
            ApprovalNumber = approvalNumber;
            Items = items;
        }
    }
}
