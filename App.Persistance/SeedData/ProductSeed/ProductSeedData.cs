using App.Core.Entities.ProductManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.ProductSeed
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                SellerId = 1,
                IsActive = true,
                Name = "Product 1",
                Slug = "product-1",
                Description = "Description for Product 1",
                Stock = 100,
                BranName = "Brand A",
                FirstPhotoUrl = "https://example.com/product1.jpg",
                RegularPrice = 29.99m,
                DiscountPrice = 19.99m,
            }
            );
        }
    }
}