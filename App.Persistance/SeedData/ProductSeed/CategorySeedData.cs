using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Tekstil",
                Slug = "tekstil"
            }
        );
        }
    }
}
