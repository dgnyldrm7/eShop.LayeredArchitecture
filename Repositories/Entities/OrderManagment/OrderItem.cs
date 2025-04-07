using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.OrderManagment
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        //public decimal TotalPrice => Quantity * ProductPrice;
    }
}    