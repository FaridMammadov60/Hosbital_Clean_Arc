using Application.Dto;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
            services.AddValidatorsFromAssemblyContaining<RegistrationCreateDtoValidator>();
            services.AddScoped<IValidator<RegistrationCreateDto>, RegistrationCreateDtoValidator>();
        }
    }
}
