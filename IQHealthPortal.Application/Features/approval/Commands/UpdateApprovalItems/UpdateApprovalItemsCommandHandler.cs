using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Commands.UpdateApprovalItems
{
    public class UpdateApprovalItemsCommandHandler
       : IRequestHandler<UpdateApprovalItemsCommand, ServiceResponse<bool>>
    {
        private readonly IUnitOfWork _uow;

        public UpdateApprovalItemsCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ServiceResponse<bool>> Handle(
            UpdateApprovalItemsCommand request,
            CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<bool>();

            await _uow.ApprovalRepository
                .UpdateApprovalItemsAsync(
                    request.ApprovalNumber,
                    request.Items);

            _uow.Save();

            response.Data = true;
            response.Success = true;
            response.Status = 200;

            return response;
        }
    }
}
