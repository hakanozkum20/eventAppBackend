using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Application.Repositories;
using eventAppAPI.Domain.Entities;
using eventAppAPI.Persistence.Contexts;

namespace eventAppAPI.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(eventAppAPIDbContext context) : base(context)
        {
        }
    }
}
