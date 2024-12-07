
using eventAppAPI.Application.Repositories;
using eventAppAPI.Application.ViewModels.Events;
using eventAppAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eventAppAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        readonly private IEventWriteRepository _eventWriteRepository;
        readonly private IEventReadRepository _eventReadRepository;

        public EventsController(IEventReadRepository eventReadRepository, IEventWriteRepository eventWriteRepository)
        {
            _eventReadRepository = eventReadRepository;
            _eventWriteRepository = eventWriteRepository;
        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok( _eventReadRepository.GetAll(false)));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return  Ok(await _eventReadRepository.GetByIdAsync(id, false));
        }


        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Event model)
        {
            if (ModelState.IsValid)
            {
                
            }
            await _eventWriteRepository.AddAsync(new()
            {
                BrideName = model.BrideName,
                BrideSurname = model.BrideSurname,
                GroomName = model.GroomName,
                GroomSurname = model.GroomSurname,
                eventTimeStart = model.eventTimeStart,
                eventTimeFinish = model.eventTimeFinish,
                Title = model.Title,
                HostedNameSurname = model.HostedNameSurname,
                Phone = model.Phone,
                NumberOfGuests = model.NumberOfGuests,
                Description = model.Description,
                eventDate = model.eventDate,
                EventType = model.EventType,
                
                

            });
            await _eventWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Event model)
        {
            Event @event = await _eventReadRepository.GetByIdAsync(model.Id);
            @event.BrideName = model.BrideName;
            @event.BrideSurname = model.BrideSurname;
            @event.GroomName = model.GroomName;
            @event.GroomSurname = model.GroomSurname;
            @event.eventTimeStart = model.eventTimeStart;
            @event.eventTimeFinish = model.eventTimeFinish;
            @event.Title = model.Title;
            @event.HostedNameSurname = model.HostedNameSurname;
            @event.Phone = model.Phone;
            @event.NumberOfGuests = model.NumberOfGuests;
            @event.Description = model.Description;
            @event.eventDate = model.eventDate;
            @event.EventType = model.EventType;
            
            await _eventWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _eventWriteRepository.RemoveAsync(id);
            await _eventWriteRepository.SaveAsync();
            return Ok();
        }




    }
}