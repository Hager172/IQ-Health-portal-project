using IQHealthPortal.Domain.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Configurations
{

    public class OnlineClientConfiguration : IEntityTypeConfiguration<OnlineClient>
    {
        public void Configure(EntityTypeBuilder<OnlineClient> builder)
        {
            // Primary Key
            builder.HasKey(e => e.ClientId);

            // Properties
            builder.Property(e => e.ClientName)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(e => e.ConnectionString)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(e => e.IsActive);

            // Relationships
            builder.HasMany(e => e.OnlineUserClients)
                   .WithOne(u => u.OnlineClient)
                   .HasForeignKey(u => u.ClientId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
