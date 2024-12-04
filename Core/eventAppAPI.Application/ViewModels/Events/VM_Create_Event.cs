using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Domain.Enums;

namespace eventAppAPI.Application.ViewModels.Events
{
    public class VM_Create_Event
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public EventType EventType { get; set; }
        public string HostedNameSurname { get; set; }
        public int Phone { get; set; }
        public int NumberOfGuests { get; set; }
        public string Description { get; set; }

    }
}