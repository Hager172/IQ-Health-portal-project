using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IPageRepository
    {
        Task<List<PageDto>> GetUserPagesAsync(string userId,int? client);
    }
}
