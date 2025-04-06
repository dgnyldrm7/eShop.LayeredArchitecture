using App.Core.Entities.OrderManagment;
using App.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.OrderSeed
{
    public class OrderSeedData : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
            new Order
            {
                Id = 1,
                UserId = 1,
                Status = OrderStatus.Shipped,
                TotalAmount = 100.00m,
                OrderDate = DateTime.UtcNow,
                PaymentId = 1,
                ShippingId = 1
            }
                    
        );
        }
    }
} 