using eventAppAPI.Domain.Enums;

namespace eventAppAPI.Application.ViewModels.Events;

public class VM_Update_Event
{
    public string Id { get; set; }
    public string BrideName { get; set; }
    public string BrideSurname { get; set; }
    public string GroomName { get; set; }
    public string GroomSurname { get; set; }
    public string eventTimeStart { get; set; }
    public string eventTimeFinish { get; set; }
    public string Title { get; set; }
    
    public EventType EventType { get; set; }
    public string HostedNameSurname { get; set; }
    public string Phone { get; set; }
    public int NumberOfGuests { get; set; }
    public string Description { get; set; }
    public string eventDate { get; set; }
}