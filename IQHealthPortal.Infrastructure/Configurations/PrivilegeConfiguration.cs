using IQHealthPortal.Domain.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Configurations
{

    public class PrivilegeConfiguration : IEntityTypeConfiguration<Privilege>
    {
        public void Configure(EntityTypeBuilder<Privilege> builder)
        {
            builder.HasOne(p => p.Page)
                   .WithMany()
                   .HasForeignKey(p => p.PageId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Role)
                   .WithMany()
                   .HasForeignKey(p => p.RoleId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
