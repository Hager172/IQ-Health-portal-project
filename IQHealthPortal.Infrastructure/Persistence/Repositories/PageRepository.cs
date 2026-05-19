
using ACMS_ONLINE_INFRASTRUCTURE.Data;
using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class PageRepository : IPageRepository
    {
        private readonly IdentityContext _context;

        public PageRepository(IdentityContext context)
        {
            _context = context;
        }
        
        public async Task<List<PageDto>> GetUserPagesAsync(string userId,int?client)
        {
            return  (from ur in _context.UserRoles
                          join pr in _context.Privileges on ur.RoleId equals pr.RoleId
                          join p in _context.Pages on pr.PageId equals p.Id
                          where ur.UserId == userId && pr.ClientId == client
                     select new PageDto
                          {
                              PageId = p.Id,
                              NameAr = p.NameAr,
                              NameEn = p.NameEn,
                              Add = pr.Add,
                              View = pr.View,
                              Edit = pr.Edit,
                              Submit = pr.Submit,
                              Unsubmit = pr.Unsubmit,
                              Cancel = pr.Cancel,
                              Import = pr.Import,
                              Export = pr.Export,
                              Print = pr.Print,
                              SpacialCase = pr.SpacialCase
                          })
                          .Distinct()
                          .AsEnumerable()
                          .ToList();
        }
    }

}
