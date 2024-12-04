using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace eventAppAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<eventAppAPIDbContext>
    {
        public eventAppAPIDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<eventAppAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new (dbContextOptionsBuilder.Options);
        }
    }
}
