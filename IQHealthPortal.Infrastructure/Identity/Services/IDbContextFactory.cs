
using IQHealthPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Infrastructure.Identity.Services
{
    public interface IDbContextFactory
    {
        ApplicationDbContext  CreateDbContext(string connectionString);
    }
}
