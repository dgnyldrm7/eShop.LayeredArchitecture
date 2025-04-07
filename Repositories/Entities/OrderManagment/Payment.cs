using App.Core.Enums;

namespace App.Core.Entities.OrderManagment
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime PaymentDate { get; set; }
        public Order Order { get; set; }       
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}