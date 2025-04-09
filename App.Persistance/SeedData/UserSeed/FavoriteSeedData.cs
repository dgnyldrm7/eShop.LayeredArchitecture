using App.Core.Entities.UserManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.UserSeed
{
    public class FavoriteSeedData : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.HasData(
            new Favorite
            {
                Id = 1,
                UserId = "1",
                ProductId = 1
            });
        }
    }
}