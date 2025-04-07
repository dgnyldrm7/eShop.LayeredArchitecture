using App.Core.Entities.OrderManagment;
using App.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.OrderSeed
{
    public class TransactionSeedData : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
            new Transaction
            {
                Id = 1,
                PaymentId = 1,
                Amount = 150.00m,
                TransactionDate = DateTime.Now,
                Status = TransactionStatus.Success                
            }
        );
        }
    }
}
