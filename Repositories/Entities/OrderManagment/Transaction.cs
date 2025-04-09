using App.Core.Common.Entities;
using App.Core.Enums;

namespace App.Core.Entities.OrderManagment
{
    public class Transaction : EntityBase<int>
    { 
        public int PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionStatus Status { get; set; }
    }
}