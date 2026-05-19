using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.VendorDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.vendor.Queries
{
    public class GetVendorWithServicesQuery
    : IRequest<ServiceResponse<VendorWithServicesDto>>
    {
        public string VendorId { get; set; }

        public GetVendorWithServicesQuery(string vendorId)
        {
            VendorId = vendorId;
        }
    }
}
