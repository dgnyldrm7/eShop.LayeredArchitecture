using App.Core.Entities.UserManagment;
using App.Core.Interfaces;
using App.Infrastructure.Caching;
using App.Persistance.DbContext;
using App.Persistance.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace App.Persistance.Extensions
{
    public static class PersistanceExtensions
    {
        public static void AddDbContexts(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                //var connectionString = configuration.GetSection(ConnectionStrings.Key).Get<ConnectionStrings>();

                string connectionString = "Data Source=TALHA\\SQLEXPRESS;Initial Catalog=EcommerceDataBase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                options.UseSqlServer(connectionString, sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly("App.Persistance");
                });
            });
        }

        public static void AddIdentityServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
        }

        public static void AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddMemoryCache();

            builder.Services.AddScoped<ICacheService, MemoryCacheService>();
        }

        public static void AddPersistanceDIContainer(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }


        public static void AddMiddlewares(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();
        }
    }
}