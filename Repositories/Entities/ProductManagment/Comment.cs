 using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = default!;
        public string UserId { get; set; } = default!;
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}