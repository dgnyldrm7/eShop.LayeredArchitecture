using App.Core.Entities.SellerManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Answer
    {
        public int Id { get; set; }
        public string Message { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}