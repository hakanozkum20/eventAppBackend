using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eventAppAPI.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private ICustomerReadRepository _customerReadRepository;

        public CustomersController(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _customerWriteRepository.AddRangeAsync(new()
            {
                new() {Id= new Guid(), Name="Hakan Özkum", Address="Istanbul", CompanyName="esta", CreatedDate=DateTime.UtcNow, Email="hakanozkum@gmail.com", Phone=12312312, },
                new() {Id=new Guid(), Name="Ahmet Yusuf Şahinci", Address="Istanbul", CompanyName="esta2", CreatedDate=DateTime.UtcNow, Email="hakanozkum1@gmail.com", Phone=100002, }
            });
            await _customerWriteRepository.SaveAsync();
        }


    }
}
