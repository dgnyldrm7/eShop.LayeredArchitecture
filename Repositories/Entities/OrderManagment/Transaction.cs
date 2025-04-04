using App.Core.Enums;

namespace App.Core.Entities.OrderManagment
{
    public class Transaction
    { 
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = new();
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
        public TransactionStatus Status { get; set; }
    }
}