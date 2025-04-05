using App.Core.Entities.OrderManagment;
using App.Core.Entities.SellerManagment;
using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;        
        public string Slug { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsActive { get; set; } = true;
        public int Stock { get; set; }
        public string BranName { get; set; } = default!;
        public string FirstPhotoUrl { get; set; } = default!;
        public decimal RegularPrice { get; set; }
        public decimal DiscountPrice { get; set; }         
        public int SellerId { get; set; } = default!;
        public Seller Seller { get; set; } = new();
        public List<CartItem>? CartItems { get; set; }
        public List<Question>? Questions { get; set; }  
        public List<OrderItem> OrderItems { get; set; } = new();
        public List<ProductPhoto> ProductPhotos { get; set; } = new();
        public List<Rating>? Ratings { get; set; }
        public List<Comment>? Comments { get; set; }
        public int CategoryId { get; set; } = default!;
        public Category Category { get; set; } = new();
    }
}