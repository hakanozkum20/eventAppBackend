using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventAppAPI.Application.Repositories;
using eventAppAPI.Application.Validators.Events;
using eventAppAPI.Application.ViewModels.Events;
using eventAppAPI.Persistence.Contexts;
using eventAppAPI.Persistence.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;




namespace eventAppAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService (this IServiceCollection services)
        {
            services.AddDbContext<eventAppAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<IEventReadRepository, EventReadRepository>();
            services.AddScoped<IEventWriteRepository, EventWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
          



        }
    }
}
