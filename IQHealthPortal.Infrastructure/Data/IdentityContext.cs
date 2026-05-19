

using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.Configurations;
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
        }


    }
}
