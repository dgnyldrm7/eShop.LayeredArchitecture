using App.Core.Entities.SellerManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.SellerSeed
{
    public class ModeratorSeedData : IEntityTypeConfiguration<Moderator>
    {
        public void Configure(EntityTypeBuilder<Moderator> builder)
        {
            builder.HasData(
            new Moderator
            {
                Id = 1,
                UserName = "hasan",
                Name = "Hasan",
                Surname = "Ali",
                Password = "password123",
                Email = "hasanali@gmail.com",
                PhoneNumber = "1234567890",
            }
            );
        }
    }
}