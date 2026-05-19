using IQHealthPortal.Application.DTOs.VendorDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
    {
    public interface IVendorRepository
        {
        Task<List<VendorBasicDto>> GetAllAsync();

        Task<List<VendorServiceDto>> GetPharmaServicesAsync(
            string vendorId,
            string vendorName);

        Task<List<VendorServiceDto>> GetContractServicesAsync(
            string vendorId,
            string vendorName);
        Task<VendorBasicDto> GetByIdAsync(string vendorId);
        }

    }
