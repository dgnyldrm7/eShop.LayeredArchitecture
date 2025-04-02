using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.UserManagment
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public required Product Product { get; set; }
    }
}
