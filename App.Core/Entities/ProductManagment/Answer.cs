using App.Core.Common.Entities;
using App.Core.Entities.SellerManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Answer : EntityBase<int>
    {
        public string Message { get; set; } = default!;
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public int SellerId { get; set; }
        public Seller? Seller { get; set; }
    }
}