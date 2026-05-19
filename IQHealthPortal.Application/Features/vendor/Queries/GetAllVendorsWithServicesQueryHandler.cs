using IQHealthPortal.Application.Common.Responses;
using IQHealthPortal.Application.DTOs.VendorDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Features.vendor.Queries
    {
    public class GetVendorWithServicesQueryHandler
    : IRequestHandler<GetVendorWithServicesQuery,
        ServiceResponse<VendorWithServicesDto>>
        {
        private readonly IUnitOfWork _unitOfWork;

        public GetVendorWithServicesQueryHandler(IUnitOfWork unitOfWork)
            {
            _unitOfWork = unitOfWork;
            }

        public async Task<ServiceResponse<VendorWithServicesDto>> Handle(
            GetVendorWithServicesQuery request,
            CancellationToken cancellationToken)
            {
            var vendor = await _unitOfWork.VendorRepository
                .GetByIdAsync(request.VendorId);

            if (vendor == null)
                {
                return new ServiceResponse<VendorWithServicesDto>
                    {
                    Success = false,
                    MessageEn = "Vendor not found"
                    };
                }

            List<VendorServiceDto> services;

            if (vendor.VendorCategoryId == 4)
                {
                services = await _unitOfWork.VendorRepository
                    .GetPharmaServicesAsync(vendor.VendorId, vendor.VendorName);
                }
            else
                {
                services = await _unitOfWork.VendorRepository
                    .GetContractServicesAsync(vendor.VendorId, vendor.VendorName);
                }

            var result = new VendorWithServicesDto
                {
                VendorId = vendor.VendorId,
                VendorName = vendor.VendorName,
                VendorCategoryId = vendor.VendorCategoryId,
                Services = services
                };

            return new ServiceResponse<VendorWithServicesDto>
                {
                Success = true,
                Data = result
                };
            }
        }
    }
