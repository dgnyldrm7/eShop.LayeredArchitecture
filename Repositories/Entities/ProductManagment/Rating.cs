using App.Core.Entities.UserManagment;

namespace App.Core.Entities.ProductManagment
{
    public class Rating
    { 
        public int Id { get; set; }
        public int Score { get; set; }
        public string UserId { get; set; } = default!;
        public AppUser? AppUser { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}