using IQHealthPortal.Application.DTOs.VendorDtos;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class VendorRepository: IVendorRepository
    {
        private readonly ApplicationDbContext _context;
        public VendorRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }
        public async Task<List<VendorBasicDto>> GetAllAsync()
        {
            return await _context.VendorGenerals
                .Where(
                v => v.VendorStatus == "V"
                )
                .Select(v => new VendorBasicDto
                {
                    VendorId = v.VendorId,
                    VendorName = v.VendorName,
                    VendorCategoryId = v.VendorCategoryId
                })
                .ToListAsync();
        }
        public async Task<VendorBasicDto> GetByIdAsync(string vendorId)
        {
            return await _context.VendorGenerals
                 //.Where(c =>
                 //   c.VendorContractStartDate <= today &&
                 //   c.VendorContractEndDate >= today)
                .Where(v => v.VendorId == vendorId)
                .Select(v => new VendorBasicDto
                {
                    VendorId = v.VendorId,
                    VendorName = v.VendorName,
                    VendorCategoryId = v.VendorCategoryId
                })
                .FirstOrDefaultAsync();
        }

        private async Task<string?> GetActiveContractIdAsync(string vendorId)
        {
            var today = DateTime.Today;

            //var contract = await _context.VendorContracts
            //    .Where(c =>
            //        c.VendorContractVendorId == vendorId 
            //        &&
            //        c.VendorContractStartDate <= today &&
            //        c.VendorContractEndDate >= today)
            //    .OrderByDescending(c => c.V
            //    endorContractStartDate)
            //    .FirstOrDefaultAsync();
            var contract = await _context.VendorContracts
                .Where(c => c.VendorContractVendorId == vendorId)
                .FirstOrDefaultAsync();

            return contract?.VendorContractId;
        }

        public async Task<List<VendorServiceDto>> GetPharmaServicesAsync(
            string vendorId,
            string vendorName)
        {
            var contractId = await GetActiveContractIdAsync(vendorId);

            if (contractId == null)
                return new List<VendorServiceDto>();

            return await _context.AcmsPharmas
                .Where(p => p.Active == 1)
                .Select(p => new VendorServiceDto
                {
                    ServiceId = p.Id.ToString(),
                    ServiceName = p.Name,
                    Price = (decimal)p.Price,
                    Discount = null,
                    Copayment = null
                })
                .ToListAsync();
            }

        public async Task<List<VendorServiceDto>> GetContractServicesAsync(
            string vendorId,
            string vendorName)
        {
            var contractId = await GetActiveContractIdAsync(vendorId);

            if (contractId == null)
                return new List<VendorServiceDto>();

            return await _context.ContractServices
                .Where(s => s.ContractServiceContractCode == contractId)
                .Select(s => new VendorServiceDto
                {
                    ServiceId = s.ContractServiceId.ToString(),
                    ServiceName = s.ContractServiceName,
                    Price = (decimal)s.ContractServicePrices,
                    Discount = (decimal?)s.ContractServiceDiscount,
                    Copayment = null
                })
                .ToListAsync();
            }
        }
    }
