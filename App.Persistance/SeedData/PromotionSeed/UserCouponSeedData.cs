using App.Core.Entities.PromotionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.PromotionSeed
{
    public class UserCouponSeedData : IEntityTypeConfiguration<UserCoupon>
    {
        public void Configure(EntityTypeBuilder<UserCoupon> builder)
        {
            builder.HasData(
            new UserCoupon
            {
                Id = 1,
                UserId = "1",
                CouponId = 1,
                IsUsed = false,
                AssignedDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddDays(30),
                UsedDate = DateTime.UtcNow.AddDays(10)
            }
            );
        }
    }
}