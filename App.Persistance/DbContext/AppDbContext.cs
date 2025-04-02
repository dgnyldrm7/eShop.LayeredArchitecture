using App.Core.Entities.UserManagment;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Persistance.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
            //
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}