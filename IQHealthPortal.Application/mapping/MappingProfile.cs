using AutoMapper;
using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.UserService.Queries.GetUserData;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Page, Pagedto>()
                .ForMember(dest => dest.SubPages, opt => opt.Ignore())
                .ForMember(dest => dest.ParentPage, opt => opt.Ignore());
        }
    }
}
