using App.Core.Entities.SellerManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.SellerSeed
{
    public class SellerSeedData : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasData(
            new Seller
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                UserName = "johndoe",
                Password = "password123",
                Email = "test@gmail.com",
                Phone = "1234567890",
                Address = "123 Main St, City, Country",
                LogoUrl = "https://example.com/logo.jpg",
                BannerUrl = "https://example.com/banner.jpg",                
            }
            );
        }
    }
}
