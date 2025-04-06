using App.Core.Entities.UserManagment;
using App.Persistance.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace App.Persistance.Extensions
{
    public static class PersistanceExtensions
    {
        public static void AddRepositories(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            //DbContext Configuration
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"), sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                });
            });

            

        }   
    }
}