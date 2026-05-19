using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetApprovalForEdit
{
    public class GetApprovalForEditQueryHandler
        : IRequestHandler<GetApprovalForEditQuery, ServiceResponse<GetApprovalForEditDto>>
    {
        private readonly IUnitOfWork _uow;

        public GetApprovalForEditQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ServiceResponse<GetApprovalForEditDto>> Handle(
            GetApprovalForEditQuery request,
            CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<GetApprovalForEditDto>();

            var approval = await _uow.ApprovalRepository
                .GetApprovalForEditAsync(request.ApprovalNumber);

            if (approval == null)
            {
                response.Success = false;
                response.Status = 404;
                return response;
            }

            response.Data = approval;
            response.Success = true;
            response.Status = 200;

            return response;
        }
    }
}
