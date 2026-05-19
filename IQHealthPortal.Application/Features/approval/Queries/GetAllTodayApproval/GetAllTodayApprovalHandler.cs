using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.ApprovalDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetAllTodayApproval
{
    internal class GetAllTodayApprovalHandler:IRequestHandler<GetAllTodayApprovalQuery,ServiceResponse<GetTodayapps>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public  GetAllTodayApprovalHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }

        public async Task <ServiceResponse<GetTodayapps>> Handle(
            GetAllTodayApprovalQuery request,
             CancellationToken cancellationToken)
        {
            var response =new ServiceResponse<GetTodayapps>();
            var approval = await _unitOfWork.ApprovalRepository.GetAllTodayApprovals(request.client_id,request.vendor_id);

            if (approval == null)
            {
                response.Success = false;
                response.Status = 404;
                return response;
            }
            var result = new GetTodayapps
            {
                vendor_id = int.TryParse(request.client_id, out var v) ? v : null,
                Approvals = approval
            };
            response.Data = result;
            response.Success = true;
            response.Status = 200;

            return response;
        }



    }
}
