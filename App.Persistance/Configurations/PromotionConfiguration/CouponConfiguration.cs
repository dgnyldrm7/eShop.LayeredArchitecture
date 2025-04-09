using App.Core.Entities.PromotionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.PromotionConfiguration
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("Coupons");

            builder.Property(c => c.DiscountAmount)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(c => c.Seller)
                   .WithMany(s => s.Coupons)
                   .HasForeignKey(c => c.SellerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
