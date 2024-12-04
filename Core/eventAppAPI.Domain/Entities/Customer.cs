using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Entities.Common;

namespace eventAppAPI.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public  string? Email { get; set; }
        public int Phone { get; set; }
        public  string? Address { get; set; }
        public string? CompanyName { get; set; }
        public  ICollection<User>? Users { get; set; }
        public ICollection<Event>? Events { get; set; }

    }
}
