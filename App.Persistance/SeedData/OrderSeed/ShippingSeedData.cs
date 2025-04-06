using App.Core.Entities.OrderManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.OrderSeed
{
    public class ShippingSeedData : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder.HasData(
            new Shipping
            {
                Id = 1,
                OrderId = 1,
                CompanyName = "MNG CARGO",
                Address = "123 Main St, Springfield, IL",
                City = "Springfield",
                State = "IL",
                ZipCode = "62701",
                ShippingDate = DateTime.UtcNow,
                DeliveryDate = DateTime.UtcNow.AddDays(5),
                TrackingNumber = "TRACK123456"
            }
        );
        }
    }
}
