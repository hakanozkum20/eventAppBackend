using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Entities.Common;
using eventAppAPI.Domain.Enums;

namespace eventAppAPI.Domain.Entities
{
    public class Event : BaseEntity
    {
        public string? Name { get; set; }
        public string Title { get; set; }
        public int Phone { get; set; }
        public Customer? Customer { get; set; }
        public string? HostedNameSurname { get; set; }
        public EventType EventType { get; set; }
        public float Price { get; set; }
        public DateTime EventDate { get; set; }
        public int NumberOfGuests { get; set; }
        public string Menu { get; set; }
        public string Description { get; set; }



    }
}
