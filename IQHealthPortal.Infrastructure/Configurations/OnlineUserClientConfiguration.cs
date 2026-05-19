using IQHealthPortal.Domain.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Configurations
{
    public class OnlineUserClientConfiguration : IEntityTypeConfiguration<OnlineUserClient>
    {
        public void Configure(EntityTypeBuilder<OnlineUserClient> builder)
        {
            // Composite Key
            builder.HasKey(e => new { e.UserId, e.ClientId });

            // Properties
            builder.Property(e => e.IsDefault)
                   .IsRequired();

            builder.Property(e => e.VendorId)
                   .HasMaxLength(50);

            // Relationships
            builder.HasOne(e => e.User)
                   .WithMany()
                   .HasForeignKey(e => e.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.OnlineClient)
                   .WithMany(c => c.OnlineUserClients)
                   .HasForeignKey(e => e.ClientId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
