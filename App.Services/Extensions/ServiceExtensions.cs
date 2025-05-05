using App.Core.Interfaces.UnitOfWork;
using App.Persistance.UnitOfWork;
using App.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace App.Services.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceDIContainer(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ProductService>();

            builder.Services.AddScoped<UserRegistrationService>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}