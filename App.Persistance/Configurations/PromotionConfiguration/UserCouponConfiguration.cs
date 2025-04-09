using App.Core.Entities.PromotionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.Configurations.PromotionConfiguration
{
    public class UserCouponConfiguration : IEntityTypeConfiguration<UserCoupon>
    {
        public void Configure(EntityTypeBuilder<UserCoupon> builder)
        {
            builder.ToTable("UserCoupons");

            builder.HasKey(uc => uc.Id);

            builder.HasOne(uc => uc.AppUser)
                   .WithMany(u => u.UserCoupons)
                   .HasForeignKey(uc => uc.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(uc => uc.Coupon)
                   .WithMany(c => c.UserCoupons)
                   .HasForeignKey(uc => uc.CouponId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
