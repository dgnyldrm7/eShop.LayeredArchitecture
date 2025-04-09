using App.Core.Entities.OrderManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.OrderConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.ToTable("Orders");

            builder.HasOne(o => o.AppUser)
                   .WithMany(u => u.Orders)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Cascade);         

            builder.HasOne(o => o.Payment)
                   .WithOne(p => p.Order)
                   .HasForeignKey<Order>(o => o.PaymentId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Shipping)
                   .WithOne(s => s.Order)
                   .HasForeignKey<Order>(o => o.ShippingId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}