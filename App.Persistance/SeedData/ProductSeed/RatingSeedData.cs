using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class RatingSeedData : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
            new Rating
            {
                Id = 1,
                ProductId = 1,
                UserId = 1,
                Score = 5,              
            });
        }
    }
}
