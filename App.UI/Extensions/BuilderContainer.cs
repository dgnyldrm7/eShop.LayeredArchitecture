using App.Core.Entities.UserManagment;
using App.Persistance.DbContext;
using App.Services.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace App.UI.Extensions
{
    public static class BuilderContainer
    {
        private static readonly IOptions<ConnectionStrings>? _connectionStrings;

        public static void AddServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddRazorPages();

            // Add services to the container. For example: Options Pattern
            builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

            //DbContext Configuration
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_connectionStrings?.Value.SqlServer);
            });

            //Identity Configuration
            builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}
