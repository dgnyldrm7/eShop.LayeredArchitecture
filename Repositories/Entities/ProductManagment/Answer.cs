using App.Core.Entities.SellerManagment;
using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Answer
    {
        public int Id { get; set; }
        public string Message { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public int QuestionId { get; set; }
        public Question Question { get; set; } = new();
        public int SellerId { get; set; }
        public Seller Seller { get; set; } = new();
    }
}
