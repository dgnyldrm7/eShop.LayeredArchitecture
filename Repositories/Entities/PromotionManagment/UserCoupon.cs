using App.Core.Entities.UserManagment;

namespace App.Core.Entities.PromotionManagment
{
    public class UserCoupon
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int CouponId { get; set; }
        public bool IsUsed { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? UsedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public Coupon Coupon { get; set; } = null!;
    }
}