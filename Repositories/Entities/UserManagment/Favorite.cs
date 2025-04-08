using App.Core.Entities.ProductManagment;

namespace App.Core.Entities.UserManagment
{
    public class Favorite
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Product? Product { get; set; }
        public AppUser? User { get; set; }
    }
}