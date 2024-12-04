using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Entities.Common;

namespace eventAppAPI.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Password { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
