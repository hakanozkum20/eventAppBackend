using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Entities;
using eventAppAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace eventAppAPI.Persistence.Contexts
{
    public class eventAppAPIDbContext : DbContext
    {
        public eventAppAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Event> Events{ get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
