using App.Core.Entities.PromotionManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistance.SeedData.PromotionSeed
{
    public class CouponSeedData : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasData(
            new Coupon
            {                
                Id = 1,
                SellerId = 1,                
                Code = "COUPON100",
                DiscountAmount = 100,
                UsageLimit = 10,
                UsedCount = 0,
                IsActive = true,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddMonths(1),
            }
            );
        }
    }
}