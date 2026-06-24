

using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.Configurations;
using IQHealthPortal.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace ACMS_ONLINE_INFRASTRUCTURE.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser, ApplicationRole,string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options): base(options)
        {

        }
        public DbSet<OnlineClient> OnlineClients { get; set; }
        public DbSet<OnlineUserClient> OnlineUserClients { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<AspNetUsersMerge> AspNetUsersMerge { get; set; }

        public DbSet<OnlineUsers> OnlineUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new OnlineUserClientConfiguration());
            builder.ApplyConfiguration(new PageConfiguration());
            builder.ApplyConfiguration(new PrivilegeConfiguration());
            builder.ApplyConfiguration(new OnlineClientConfiguration());
            builder.Entity<Privilege>()
    .HasOne(p => p.Client)
    .WithMany()
    .HasForeignKey(p => p.ClientId)
    .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<AspNetUsersMerge>()
          .HasKey(x => new { x.UserId, x.UserId1 });


            builder.Entity<AspNetUsersMerge>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<AspNetUsersMerge>()
                .HasOne(x => x.User1)
                .WithMany()
                .HasForeignKey(x => x.UserId1)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OnlineUsers>()
    .HasOne(x => x.User)
    .WithMany()
    .HasForeignKey(x => x.UserId)
    .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<OnlineUsers>()
                .HasOne(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<OnlineUsers>()
                .HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
