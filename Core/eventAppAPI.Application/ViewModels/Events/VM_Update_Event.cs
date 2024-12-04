using eventAppAPI.Domain.Enums;

namespace eventAppAPI.Application.ViewModels.Events;

public class VM_Update_Event
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Name { get; set; }
    public EventType EventType { get; set; }
    public string HostedNameSurname { get; set; }
    public int Phone { get; set; }
    public int NumberOfGuests { get; set; }
    public string Description { get; set; }
}