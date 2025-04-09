using App.Core.Common.Entities;
using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.UserManagment
{
    public class CartItem : EntityBase<int>
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        //public int TotalPrice => (int)(Quantity * Product.DiscountPrice);
        public Product? Product { get; set; }
        public Cart? Cart { get; set; }
    }
}