using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.PromotionManagment
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
