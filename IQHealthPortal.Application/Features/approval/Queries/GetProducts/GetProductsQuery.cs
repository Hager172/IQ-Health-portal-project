using IQHealthPortal.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.approval.Queries.GetProducts
{
    public class GetProductsquery : IRequest<List<ProductLookupDto>>
    {
        public string? Term { get; set; }
        public string VType { get; set; }
    }
}
