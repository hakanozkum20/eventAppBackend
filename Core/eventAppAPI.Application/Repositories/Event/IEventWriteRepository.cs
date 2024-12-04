using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Entities;

namespace eventAppAPI.Application.Repositories
{
    public interface IEventWriteRepository : IWriteRepository<Event>
    {

    }
}
