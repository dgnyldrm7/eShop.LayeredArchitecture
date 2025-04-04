 using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = default!;
        // Navigation properties
        public int UserId { get; set; }
        public AppUser User { get; set; } = new();
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}