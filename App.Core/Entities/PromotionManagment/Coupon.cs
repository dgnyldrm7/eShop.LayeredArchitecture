using App.Core.Common.Entities;
using App.Core.Entities.SellerManagment;

namespace App.Core.Entities.PromotionManagment
{
    public class Coupon : EntityBase<int>
    {
        public string? Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public int UsageLimit { get; set; }
        public int UsedCount { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SellerId { get; set; } = default!;
        public Seller? Seller { get; set; }
        public List<UserCoupon>? UserCoupons { get; set; }
    }
}