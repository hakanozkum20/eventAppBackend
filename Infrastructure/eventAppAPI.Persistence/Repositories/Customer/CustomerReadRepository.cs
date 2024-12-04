using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Application.Repositories;
using eventAppAPI.Domain.Entities;
using eventAppAPI.Persistence.Contexts;

namespace eventAppAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(eventAppAPIDbContext context) : base(context)
        {
        }
    }
}
