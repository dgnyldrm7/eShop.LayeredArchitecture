using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.UserSeed
{
    public class AppUserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
            new AppUser
            {                
                Id = "1",
                UserName = "testuser",
                NormalizedUserName = "TESTUSER",
                Email = "test@example.com",
                NormalizedEmail = "TEST@EXAMPLE.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905551112233",
                PhoneNumberConfirmed = true,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                PasswordHash = "AQAAAAEAACcQAAAAEC4tNDZ4Q3kuvHQGgXV6mkzUayYGuXl0f3kRU6dPFE0Uj6gYX4ZmuCN6PMIqP6ZxDQ==" // "Test123*"
            }    
            );
        }
    }
}
