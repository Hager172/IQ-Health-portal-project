using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<
            GetProductsquery,
            List<ProductLookupDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetProductsQueryHandler(
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<ProductLookupDto>>
            Handle(
                GetProductsquery request,
                CancellationToken cancellationToken)
        {
            if (request.VType == "Ph")
            {
                return await unitOfWork.ClaimRepository
                    .SearchPharmaProductsAsync(request.Term);
            }

            return await unitOfWork.ClaimRepository
                .SearchContractServicesAsync(request.Term);
        }
    }
}

