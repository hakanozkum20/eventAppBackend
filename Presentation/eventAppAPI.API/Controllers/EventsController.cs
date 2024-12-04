using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Get()
        {
            return Ok(_eventReadRepository.GetAll(false));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(_eventReadRepository.GetByIdAsync(id, false));
        }


        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Event model)
        {
            await _eventWriteRepository.AddAsync(new()
            {
                Name = model.Name,
                Title = model.Title,
                HostedNameSurname = model.HostedNameSurname,
                Phone = model.Phone,
                NumberOfGuests = model.NumberOfGuests,
                Description = model.Description

            });
            await _eventWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Event model)
        {
            Event @event = await _eventReadRepository.GetByIdAsync(model.Id);
            @event.Name = model.Name;
            @event.Title = model.Title;
            @event.HostedNameSurname = model.HostedNameSurname;
            @event.Phone = model.Phone;
            @event.NumberOfGuests = model.NumberOfGuests;
            @event.Description = model.Description;
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