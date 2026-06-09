using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdentityContext>
    {
        public IdentityContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IdentityContext>();
            optionsBuilder.UseSqlServer("data source=GTHJKL\\SQLEXPRESS;initial catalog=IQHealthPortalDb;persist security info=True;user id=acms_login;password=acms@bms;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");

            return new IdentityContext(optionsBuilder.Options);
        }
}

}
