namespace App.Core.Entities.PromotionManagment
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; } = default!;
        public decimal DiscountAmount { get; set; }
        public int UsageLimit { get; set; }
        public int UsedCount { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
