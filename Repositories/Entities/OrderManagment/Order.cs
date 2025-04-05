using App.Core.Entities.UserManagment;
using App.Core.Enums;

namespace App.Core.Entities.OrderManagment
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; } = new();
        public OrderStatus Status { get; set; }        
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;       
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = new();
        public List<OrderItem> OrderItems { get; set; } = new();
        public int ShippingId { get; set; }
        public Shipping Shipping { get; set; } = new();
    }
}