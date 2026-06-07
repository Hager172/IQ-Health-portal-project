using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetDiagnosis
{
    public class GetDiagnosisQueryHandler : IRequestHandler<GetDiagnosisQuery,List<DiagnosisDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetDiagnosisQueryHandler(
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<DiagnosisDto>> Handle(
            GetDiagnosisQuery request,
            CancellationToken cancellationToken)
        {
            return await unitOfWork.ClaimRepository.GetDiagnosisAsync(request.Term);
        }
    }
}

