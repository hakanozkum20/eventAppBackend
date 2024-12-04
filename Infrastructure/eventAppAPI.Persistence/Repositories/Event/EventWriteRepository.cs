using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Application.Repositories;
using eventAppAPI.Domain.Entities;
using eventAppAPI.Persistence.Contexts;

namespace eventAppAPI.Persistence.Repositories
{
    public class EventWriteRepository : WriteRepository<Event>, IEventWriteRepository
    {
        public EventWriteRepository(eventAppAPIDbContext context) : base(context)
        {
        }
    }
}
