using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetDiagnosis
{
    public class GetDiagnosisQuery : IRequest<List<DiagnosisDto>>
    {
        public string? Term { get; set; }

    }
}
