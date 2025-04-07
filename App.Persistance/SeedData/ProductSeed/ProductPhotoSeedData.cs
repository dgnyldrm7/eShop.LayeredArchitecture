using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class ProductPhotoSeedData : IEntityTypeConfiguration<ProductPhoto>
    {
        public void Configure(EntityTypeBuilder<ProductPhoto> builder)
        {
            builder.HasData(
            new ProductPhoto
            {                
                Id = 1,
                ProductId = 1,
                Url = "https://example.com/photo1.jpg",
            }
            );
        }
    }
}