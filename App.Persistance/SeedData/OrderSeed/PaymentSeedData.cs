using App.Core.Entities.OrderManagment;
using App.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.OrderSeed
{
    public class PaymentSeedData : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
            new Payment
            {
                Id = 1,
                OrderId = 1,
                PaymentMethod = PaymentMethod.CreditCard,
                Status = PaymentStatus.Success,
                PaymentDate = DateTime.Now,
                TransactionId = 1                
            }
        );
        }
    }
}