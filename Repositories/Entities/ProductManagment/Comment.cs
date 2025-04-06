 using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = default!;
        public int UserId { get; set; }
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}