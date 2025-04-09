using App.Core.Entities.OrderManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.OrderConfiguration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Transactions");

            builder.Property(t => t.Amount)
                .HasColumnType("decimal(18,2)");
        }
    }
}
