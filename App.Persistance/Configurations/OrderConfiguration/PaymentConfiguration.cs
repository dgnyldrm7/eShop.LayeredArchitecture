using App.Core.Entities.OrderManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.OrderConfiguration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Transaction)
                   .WithOne(t => t.Payment)
                   .HasForeignKey<Payment>(p => p.TransactionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
