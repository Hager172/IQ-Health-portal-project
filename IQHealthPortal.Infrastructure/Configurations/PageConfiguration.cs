using IQHealthPortal.Domain.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Configurations
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasOne(x => x.ParentPage)
                   .WithMany(x => x.SubPages)
                   .HasForeignKey(x => x.PageParentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
