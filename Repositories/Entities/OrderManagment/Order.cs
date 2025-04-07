using App.Core.Entities.UserManagment;
using App.Core.Enums;

namespace App.Core.Entities.OrderManagment
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = default!;
        public AppUser AppUser { get; set; }
        public OrderStatus Status { get; set; }        
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }      
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingId { get; set; }
        public Shipping Shipping { get; set; }
    }
}